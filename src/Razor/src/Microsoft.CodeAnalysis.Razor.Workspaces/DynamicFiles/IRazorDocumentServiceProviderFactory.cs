﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.ExternalAccess.Razor;

namespace Microsoft.CodeAnalysis.Razor.DynamicFiles;

internal interface IRazorDocumentServiceProviderFactory
{
    IRazorDocumentServiceProvider CreateEmpty();
    IRazorDocumentServiceProvider Create(IDynamicDocumentContainer documentContainer);
}
