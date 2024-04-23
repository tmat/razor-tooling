﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Razor.Logging;
using Microsoft.VisualStudio.Razor.Logging;

namespace Microsoft.VisualStudio.LanguageServices.Razor.Logging;

/// <summary>
/// An <see cref="ILoggerProvider"/> that logs any warnings or errors to the Visual Studio Activity Log.
/// </summary>
[Export(typeof(ILoggerProvider))]
[method: ImportingConstructor]
internal sealed partial class ActivityLogLoggerProvider(ActivityLog activityLog) : ILoggerProvider
{
    private readonly ActivityLog _activityLog = activityLog;

    public ILogger CreateLogger(string categoryName)
        => new Logger(_activityLog, categoryName);
}
