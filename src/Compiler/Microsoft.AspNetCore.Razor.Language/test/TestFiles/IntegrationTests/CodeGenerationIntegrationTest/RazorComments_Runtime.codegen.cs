﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a9d16af76d3b638c489fe4ce4511816619e1713e1515ec0ce13b898e140dde7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorComments), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a9d16af76d3b638c489fe4ce4511816619e1713e1515ec0ce13b898e140dde7d", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>This should ");
            WriteLiteral(" be shown</p>\r\n\r\n");
#nullable restore
#line (5,40)-(6,21) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"

    Exception foo = 

#line default
#line hidden
#nullable disable

#nullable restore
#line (6,50)-(10,1) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"
 null;
    if(foo != null) {
        throw foo;
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line (12,3)-(12,27) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"
 var bar = "@* bar *@"; 

#line default
#line hidden
#nullable disable

            WriteLiteral("<p>But this should show the comment syntax: ");
            Write(
#nullable restore
#line (13,46)-(13,49) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"
bar

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n\r\n");
            Write(
#nullable restore
#line (15,3)-(15,4) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"
a

#line default
#line hidden
#nullable disable
#nullable restore
#line (15,8)-(15,9) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorComments.cshtml"
b

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n<input value=\"@*this razor comment is the actual value*@\" type=\"text\" />\r\n<input ");
            WriteLiteral(" type=\"text\" />\r\n");
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