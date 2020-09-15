﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.ExternalAccess.Razor;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Remote.Razor;

namespace Microsoft.VisualStudio.LanguageServices.Razor
{
    internal class OOPTagHelperResolver : TagHelperResolver
    {
        private readonly DefaultTagHelperResolver _defaultResolver;
        private readonly ProjectSnapshotProjectEngineFactory _factory;
        private readonly ErrorReporter _errorReporter;
        private readonly Workspace _workspace;

        public OOPTagHelperResolver(ProjectSnapshotProjectEngineFactory factory, ErrorReporter errorReporter, Workspace workspace)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            if (errorReporter == null)
            {
                throw new ArgumentNullException(nameof(errorReporter));
            }

            if (workspace == null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }

            _factory = factory;
            _errorReporter = errorReporter;
            _workspace = workspace;

            _defaultResolver = new DefaultTagHelperResolver();
        }

        public override async Task<TagHelperResolutionResult> GetTagHelpersAsync(Project workspaceProject, ProjectSnapshot projectSnapshot, CancellationToken cancellationToken = default)
        {
            if (workspaceProject == null)
            {
                throw new ArgumentNullException(nameof(workspaceProject));
            }

            if (projectSnapshot == null)
            {
                throw new ArgumentNullException(nameof(projectSnapshot));
            }

            if (projectSnapshot.Configuration == null)
            {
                return TagHelperResolutionResult.Empty;
            }

            // Not every custom factory supports the OOP host. Our priority system should work like this:
            //
            // 1. Use custom factory out of process
            // 2. Use custom factory in process
            // 3. Use fallback factory in process
            //
            // Calling into RazorTemplateEngineFactoryService.Create will accomplish #2 and #3 in one step.
            var factory = _factory.FindSerializableFactory(projectSnapshot);

            try
            {
                TagHelperResolutionResult result = null;
                if (factory != null)
                {
                    result = await ResolveTagHelpersOutOfProcessAsync(factory, workspaceProject, projectSnapshot).ConfigureAwait(false);
                }

                if (result == null)
                {
                    // Was unable to get tag helpers OOP, fallback to default behavior.
                    result = await ResolveTagHelpersInProcessAsync(workspaceProject, projectSnapshot).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(
                    Resources.FormatUnexpectedException(
                        typeof(DefaultTagHelperResolver).FullName,
                        nameof(GetTagHelpersAsync)),
                    exception);
            }
        }

        protected virtual async Task<TagHelperResolutionResult> ResolveTagHelpersOutOfProcessAsync(IProjectEngineFactory factory, Project workspaceProject, ProjectSnapshot projectSnapshot)
        {
            // We're being overly defensive here because the OOP host can return null for the client/session/operation
            // when it's disconnected (user stops the process).
            //
            // This will change in the future to an easier to consume API but for VS RTM this is what we have.
            var remoteClient = await RazorRemoteHostClient.CreateAsync(_workspace, CancellationToken.None);

            var factoryTypeName = factory?.GetType().AssemblyQualifiedName;

            var result = await remoteClient.TryInvokeAsync<IRemoteLanguageService, TagHelperResolutionResult>(
                workspaceProject.Solution,
                (service, solutionInfo, cancellationToken) => service.GetTagHelpersAsync(solutionInfo, projectSnapshot, factoryTypeName, cancellationToken),
                callbackTarget: null,
                CancellationToken.None).ConfigureAwait(false);

            return result.HasValue ? result.Value : null;
        }

        protected virtual Task<TagHelperResolutionResult> ResolveTagHelpersInProcessAsync(Project project, ProjectSnapshot projectSnapshot)
        {
            return _defaultResolver.GetTagHelpersAsync(project, projectSnapshot);
        }
    }
}
