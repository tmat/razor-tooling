﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8d4533fb0fc90f8228aa0b0c9ec2d1cb53d3ef9b2018884e3e906a63b2e7ec39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_MarkupInCodeBlock), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8d4533fb0fc90f8228aa0b0c9ec2d1cb53d3ef9b2018884e3e906a63b2e7ec39", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_MarkupInCodeBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line (1,3)-(3,1) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml"

    for(int i = 1; i <= 10; i++) {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p>Hello from C#, #");
            Write(
#nullable restore
#line (3,30)-(3,42) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml"
i.ToString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line (4,1)-(5,1) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/MarkupInCodeBlock.cshtml"
    }

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591