﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.LanguageServer.Hosting;
using Microsoft.AspNetCore.Razor.PooledObjects;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.Logging;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Razor.Protocol;
using Microsoft.CodeAnalysis.Razor.Workspaces;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Microsoft.VisualStudio.Threading;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Diagnostics;

internal partial class RazorDiagnosticsPublisher : IDocumentProcessedListener, IDisposable
{
    private static readonly TimeSpan s_publishDelay = TimeSpan.FromSeconds(2);
    private static readonly TimeSpan s_clearClosedDocumentsDelay = TimeSpan.FromSeconds(5);

    private readonly IProjectSnapshotManager _projectManager;
    private readonly ProjectSnapshotManagerDispatcher _dispatcher;
    private readonly IClientConnection _clientConnection;
    private readonly Dictionary<string, IDocumentSnapshot> _work;
    private readonly ILogger _logger;
    private readonly LanguageServerFeatureOptions _options;
    private readonly Lazy<RazorTranslateDiagnosticsService> _translateDiagnosticsService;
    private readonly Lazy<IDocumentContextFactory> _documentContextFactory;
    private readonly TimeSpan _publishDelay;

    private readonly CancellationTokenSource _disposeTokenSource;

    private readonly object _publishedDiagnosticsGate = new();
    private readonly Dictionary<string, IReadOnlyList<RazorDiagnostic>> _publishedRazorDiagnostics;
    private readonly Dictionary<string, IReadOnlyList<Diagnostic>> _publishedCSharpDiagnostics;

    private readonly object _documentClosedGate = new();
    private Task _clearClosedDocumentsTask = Task.CompletedTask;
    private bool _waitingToClearClosedDocuments;

    private Timer? _workTimer;

    private ManualResetEventSlim? _blockBackgroundWorkCompleting;
    private ManualResetEventSlim? _notifyBackgroundWorkCompleting;

    public RazorDiagnosticsPublisher(
        IProjectSnapshotManager projectManager,
        ProjectSnapshotManagerDispatcher dispatcher,
        IClientConnection clientConnection,
        LanguageServerFeatureOptions options,
        Lazy<RazorTranslateDiagnosticsService> translateDiagnosticsService,
        Lazy<IDocumentContextFactory> documentContextFactory,
        ILoggerFactory loggerFactory)
        : this(projectManager, dispatcher, clientConnection,
               options, translateDiagnosticsService, documentContextFactory,
               loggerFactory, s_publishDelay)
    {
    }

    // Present for test to specify publish delay
    protected RazorDiagnosticsPublisher(
        IProjectSnapshotManager projectManager,
        ProjectSnapshotManagerDispatcher dispatcher,
        IClientConnection clientConnection,
        LanguageServerFeatureOptions languageServerFeatureOptions,
        Lazy<RazorTranslateDiagnosticsService> razorTranslateDiagnosticsService,
        Lazy<IDocumentContextFactory> documentContextFactory,
        ILoggerFactory loggerFactory,
        TimeSpan publishDelay)
    {
        _projectManager = projectManager;
        _dispatcher = dispatcher;
        _clientConnection = clientConnection;
        _options = languageServerFeatureOptions;
        _translateDiagnosticsService = razorTranslateDiagnosticsService;
        _documentContextFactory = documentContextFactory;

        _disposeTokenSource = new();
        _publishedRazorDiagnostics = new Dictionary<string, IReadOnlyList<RazorDiagnostic>>(FilePathComparer.Instance);
        _publishedCSharpDiagnostics = new Dictionary<string, IReadOnlyList<Diagnostic>>(FilePathComparer.Instance);
        _work = new Dictionary<string, IDocumentSnapshot>(FilePathComparer.Instance);
        _logger = loggerFactory.GetOrCreateLogger<RazorDiagnosticsPublisher>();
        _publishDelay = publishDelay;
    }

    public void Dispose()
    {
        _workTimer?.Dispose();

        _disposeTokenSource.Cancel();
        _disposeTokenSource.Dispose();
    }

    public void DocumentProcessed(RazorCodeDocument codeDocument, IDocumentSnapshot document)
    {
        if (document is null)
        {
            throw new ArgumentNullException(nameof(document));
        }

        _dispatcher.AssertRunningOnDispatcher();

        lock (_work)
        {
            var filePath = document.FilePath.AssumeNotNull();
            _work[filePath] = document;
            StartWorkTimer();
            StartDelayToClearDocuments();
        }
    }

    private void StartWorkTimer()
    {
        // Access to the timer is protected by the lock in Synchronize and in Timer_Tick
        // Timer will fire after a fixed delay, but only once.
        _workTimer ??= new Timer(WorkTimer_Tick, state: null, dueTime: _publishDelay, period: Timeout.InfiniteTimeSpan);
    }

    private void StartDelayToClearDocuments()
    {
        lock (_documentClosedGate)
        {
            if (_waitingToClearClosedDocuments)
            {
                return;
            }

            _clearClosedDocumentsTask = ClearClosedDocumentsAfterDelayAsync();
            _waitingToClearClosedDocuments = true;
        }

        async Task ClearClosedDocumentsAfterDelayAsync()
        {
            await Task.Delay(s_clearClosedDocumentsDelay, _disposeTokenSource.Token).ConfigureAwait(false);

            ClearClosedDocuments();

            lock (_documentClosedGate)
            {
                _waitingToClearClosedDocuments = false;
            }
        }
    }

    private void ClearClosedDocuments()
    {
        lock (_publishedDiagnosticsGate)
        {
            ClearClosedDocumentsPublishedDiagnostics(_publishedRazorDiagnostics);
            ClearClosedDocumentsPublishedDiagnostics(_publishedCSharpDiagnostics);

            if (_publishedRazorDiagnostics.Count > 0 || _publishedCSharpDiagnostics.Count > 0)
            {
                // There's no way for us to know when a document is closed at this layer. Therefore, we need to poll every X seconds
                // and check if the currently tracked documents are closed. In practice this work is super minimal.
                StartDelayToClearDocuments();
            }

            void ClearClosedDocumentsPublishedDiagnostics<T>(Dictionary<string, IReadOnlyList<T>> publishedDiagnostics) where T : class
            {
                using var documentsToRemove = new PooledArrayBuilder<(string key, bool publicEmptyDiagnostics)>(capacity: publishedDiagnostics.Count);

                foreach (var (key, value) in publishedDiagnostics)
                {
                    if (!_projectManager.IsDocumentOpen(key))
                    {
                        // If there were previously published diagnostics for this document, take note so
                        // we can publish an empty set of diagnostics.
                        documentsToRemove.Add((key, publicEmptyDiagnostics: value.Count > 0));
                    }
                }

                if (documentsToRemove.Count == 0)
                {
                    return;
                }

                foreach (var (key, publicEmptyDiagnostics) in documentsToRemove)
                {
                    publishedDiagnostics.Remove(key);

                    if (publicEmptyDiagnostics)
                    {
                        PublishDiagnosticsForFilePath(key, []);
                    }
                }
            }
        }
    }

    private async Task PublishDiagnosticsAsync(IDocumentSnapshot document)
    {
        var result = await document.GetGeneratedOutputAsync().ConfigureAwait(false);

        Diagnostic[]? csharpDiagnostics = null;
        if (_options.DelegateToCSharpOnDiagnosticPublish)
        {
            var uriBuilder = new UriBuilder()
            {
                Scheme = Uri.UriSchemeFile,
                Path = document.FilePath,
                Host = string.Empty,
            };

            var delegatedParams = new DocumentDiagnosticParams
            {
                TextDocument = new TextDocumentIdentifier { Uri = uriBuilder.Uri },
            };

            var delegatedResponse = await _clientConnection.SendRequestAsync<DocumentDiagnosticParams, SumType<FullDocumentDiagnosticReport, UnchangedDocumentDiagnosticReport>?>(
                CustomMessageNames.RazorCSharpPullDiagnosticsEndpointName,
                delegatedParams,
                _disposeTokenSource.Token).ConfigureAwait(false);

            if (delegatedResponse.HasValue &&
                delegatedResponse.Value.TryGetFirst(out var fullDiagnostics) &&
                fullDiagnostics.Items is not null)
            {
                var documentContext = await _documentContextFactory.Value
                    .TryCreateAsync(delegatedParams.TextDocument.Uri, projectContext: null, _disposeTokenSource.Token)
                    .ConfigureAwait(false);

                if (documentContext is not null)
                {
                    csharpDiagnostics = await _translateDiagnosticsService.Value
                        .TranslateAsync(RazorLanguageKind.CSharp, fullDiagnostics.Items, documentContext, _disposeTokenSource.Token)
                        .ConfigureAwait(false);
                }
            }
        }

        var razorDiagnostics = result.GetCSharpDocument().Diagnostics;

        lock (_publishedDiagnosticsGate)
        {
            var filePath = document.FilePath.AssumeNotNull();

            if (_publishedRazorDiagnostics.TryGetValue(filePath, out var previousRazorDiagnostics) && razorDiagnostics.SequenceEqual(previousRazorDiagnostics)
                && (csharpDiagnostics == null || (_publishedCSharpDiagnostics.TryGetValue(filePath, out var previousCsharpDiagnostics) && csharpDiagnostics.SequenceEqual(previousCsharpDiagnostics))))
            {
                // Diagnostics are the same as last publish
                return;
            }

            _publishedRazorDiagnostics[filePath] = razorDiagnostics;
            if (csharpDiagnostics != null)
            {
                _publishedCSharpDiagnostics[filePath] = csharpDiagnostics;
            }
        }

        if (!document.TryGetText(out var sourceText))
        {
            Debug.Fail("Document source text should already be available.");
            return;
        }

        var convertedDiagnostics = razorDiagnostics.Select(razorDiagnostic => RazorDiagnosticConverter.Convert(razorDiagnostic, sourceText, document));
        var combinedDiagnostics = csharpDiagnostics == null ? convertedDiagnostics : convertedDiagnostics.Concat(csharpDiagnostics);
        PublishDiagnosticsForFilePath(document.FilePath, combinedDiagnostics);

        if (_logger.IsEnabled(LogLevel.Trace))
        {
            var diagnosticString = string.Join(", ", razorDiagnostics.Select(diagnostic => diagnostic.Id));
            _logger.LogTrace($"Publishing diagnostics for document '{document.FilePath}': {diagnosticString}");
        }
    }

    private void WorkTimer_Tick(object? state)
    {
        WorkTimer_TickAsync().Forget();
    }

    private async Task WorkTimer_TickAsync()
    {
        try
        {
            IDocumentSnapshot[] documents;
            lock (_work)
            {
                documents = _work.Values.ToArray();
                _work.Clear();
            }

            for (var i = 0; i < documents.Length; i++)
            {
                var document = documents[i];
                await PublishDiagnosticsAsync(document).ConfigureAwait(false);
            }

            OnCompletingBackgroundWork();

            lock (_work)
            {
                // Suppress analyzer that suggests using DisposeAsync().
#pragma warning disable VSTHRD103 // Call async methods when in an async method

                // Resetting the timer allows another batch of work to start.
                _workTimer?.Dispose();
                _workTimer = null;

#pragma warning restore VSTHRD103 // Call async methods when in an async method

                // If more work came in while we were running start the timer again.
                if (_work.Count > 0)
                {
                    StartWorkTimer();
                }
            }
        }
        catch
        {
            lock (_work)
            {
                // Suppress analyzer that suggests using DisposeAsync().

#pragma warning disable VSTHRD103 // Call async methods when in an async method

                // Resetting the timer allows another batch of work to start.
                _workTimer?.Dispose();
                _workTimer = null;

#pragma warning restore VSTHRD103 // Call async methods when in an async method
            }

            throw;
        }
    }

    private void OnCompletingBackgroundWork()
    {
        if (_notifyBackgroundWorkCompleting is { } notifyResetEvent)
        {
            notifyResetEvent.Set();
        }

        if (_blockBackgroundWorkCompleting is { } blockResetEvent)
        {
            blockResetEvent.Wait();
            blockResetEvent.Reset();
        }
    }

    private void PublishDiagnosticsForFilePath(string filePath, IEnumerable<Diagnostic> diagnostics)
    {
        var uriBuilder = new UriBuilder()
        {
            Scheme = Uri.UriSchemeFile,
            Path = filePath,
            Host = string.Empty,
        };

        _clientConnection
            .SendNotificationAsync(
                Methods.TextDocumentPublishDiagnosticsName,
                new PublishDiagnosticParams()
                {
                    Uri = uriBuilder.Uri,
                    Diagnostics = diagnostics.ToArray(),
                },
                _disposeTokenSource.Token)
            .Forget();
    }
}
