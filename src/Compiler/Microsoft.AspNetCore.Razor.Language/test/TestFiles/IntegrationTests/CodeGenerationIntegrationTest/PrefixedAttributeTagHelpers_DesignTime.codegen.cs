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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_PrefixedAttributeTagHelpers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::TestNamespace.InputTagHelper1 __TestNamespace_InputTagHelper1;
        private global::TestNamespace.InputTagHelper2 __TestNamespace_InputTagHelper2;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((global::System.Action)(() => {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
  
    var literate = "or illiterate";
    var intDictionary = new Dictionary<string, int>
    {
        { "three", 3 },
    };
    var stringDictionary = new SortedDictionary<string, string>
    {
        { "name", "value" },
    };

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper1 = CreateTagHelper<global::TestNamespace.InputTagHelper1>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
__TestNamespace_InputTagHelper1.IntDictionaryProperty = intDictionary;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty = __TestNamespace_InputTagHelper1.IntDictionaryProperty;
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
                  __TestNamespace_InputTagHelper1.StringDictionaryProperty = stringDictionary;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.StringDictionaryProperty = __TestNamespace_InputTagHelper1.StringDictionaryProperty;
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper1 = CreateTagHelper<global::TestNamespace.InputTagHelper1>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
__TestNamespace_InputTagHelper1.IntDictionaryProperty = intDictionary;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty = __TestNamespace_InputTagHelper1.IntDictionaryProperty;
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
           __TestNamespace_InputTagHelper1.IntDictionaryProperty["garlic"] = 37;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["garlic"] = __TestNamespace_InputTagHelper1.IntDictionaryProperty["garlic"];
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
                                                       __TestNamespace_InputTagHelper1.IntProperty = 42;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["grabber"] = __TestNamespace_InputTagHelper1.IntProperty;
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper1 = CreateTagHelper<global::TestNamespace.InputTagHelper1>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
#nullable restore
#line 19 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
__TestNamespace_InputTagHelper1.IntProperty = 42;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["grabber"] = __TestNamespace_InputTagHelper1.IntProperty;
#nullable restore
#line 19 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
__TestNamespace_InputTagHelper1.IntDictionaryProperty["salt"] = 37;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["salt"] = __TestNamespace_InputTagHelper1.IntDictionaryProperty["salt"];
#nullable restore
#line 19 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
         __TestNamespace_InputTagHelper1.IntDictionaryProperty["pepper"] = 98;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["pepper"] = __TestNamespace_InputTagHelper1.IntDictionaryProperty["pepper"];
            __TestNamespace_InputTagHelper1.StringProperty = "string";
            __TestNamespace_InputTagHelper2.StringDictionaryProperty["grabber"] = __TestNamespace_InputTagHelper1.StringProperty;
            __TestNamespace_InputTagHelper1.StringDictionaryProperty["paprika"] = "another string";
            __TestNamespace_InputTagHelper2.StringDictionaryProperty["paprika"] = __TestNamespace_InputTagHelper1.StringDictionaryProperty["paprika"];
#nullable restore
#line 21 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
                                    __o = literate;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper1.StringDictionaryProperty["cumin"] = string.Empty;
            __TestNamespace_InputTagHelper2.StringDictionaryProperty["cumin"] = __TestNamespace_InputTagHelper1.StringDictionaryProperty["cumin"];
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper1 = CreateTagHelper<global::TestNamespace.InputTagHelper1>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
#nullable restore
#line 22 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/PrefixedAttributeTagHelpers.cshtml"
__TestNamespace_InputTagHelper1.IntDictionaryProperty["value"] = 37;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper2.IntDictionaryProperty["value"] = __TestNamespace_InputTagHelper1.IntDictionaryProperty["value"];
            __TestNamespace_InputTagHelper1.StringDictionaryProperty["thyme"] = "string";
            __TestNamespace_InputTagHelper2.StringDictionaryProperty["thyme"] = __TestNamespace_InputTagHelper1.StringDictionaryProperty["thyme"];
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