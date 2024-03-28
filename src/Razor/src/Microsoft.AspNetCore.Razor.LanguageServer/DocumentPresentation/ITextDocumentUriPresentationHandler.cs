﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.LanguageServer.EndpointContracts;
using Microsoft.CodeAnalysis.Razor.Workspaces.Protocol.DocumentPresentation;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.AspNetCore.Razor.LanguageServer.DocumentPresentation;

[RazorLanguageServerEndpoint(VSInternalMethods.TextDocumentUriPresentationName)]
internal interface ITextDocumentUriPresentationHandler : IRazorRequestHandler<UriPresentationParams, WorkspaceEdit?>, ICapabilitiesProvider
{
}
