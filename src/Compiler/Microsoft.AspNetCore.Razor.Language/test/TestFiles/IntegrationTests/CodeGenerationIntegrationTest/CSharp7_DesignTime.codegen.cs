﻿// <auto-generated/>
#pragma warning disable 1591
namespace AspNetCore
{
    #line default
    using TModel = global::System.Object;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_CSharp7 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
      
        var nameLookup = new Dictionary<string, (string FirstName, string LastName, object Extra)>()
        {
            ["John Doe"] = ("John", "Doe", true)
        };

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
                                                     

        int Sixteen = 0b0001_0000;
        long BillionsAndBillions = 100_000_000_000;
        double AvogadroConstant = 6.022_140_857_747_474e23;
        decimal GoldenRatio = 1.618_033_988_749_894_848_204_586_834_365_638_117_720_309_179M;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
     if (nameLookup.TryGetValue("John Doe", out var entry))
    {
        if (entry.Extra is bool alive)
        {
            // Do Something
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
                                 __o = 1.618_033_988_749_894_848_204_586_834_365_638_117_720_309_179M;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
    __o = (First: "John", Last: "Doe").First;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp7.cshtml"
     switch (entry.Extra)
    {
        case int age:
            // Do something
            break;
        case IEnumerable<string> childrenNames:
            // Do more something
            break;
        case null:
            // Do even more of something
            break;
    }

#line default
#line hidden
#nullable disable
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
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