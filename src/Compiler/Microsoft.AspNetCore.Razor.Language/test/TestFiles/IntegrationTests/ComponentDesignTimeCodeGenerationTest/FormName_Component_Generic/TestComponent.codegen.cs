﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    #nullable restore
    public partial class TestComponent<
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
T

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((global::System.Action)(() => {
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            var __typeInference_CreateTestComponent_0 = global::__Blazor.Test.TestComponent.TypeInference.CreateTestComponent_0(__builder, -1, -1, "", -1, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                                        () => { }

#line default
#line hidden
#nullable disable
            ), -1, "", -1, 
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                             1

#line default
#line hidden
#nullable disable
            );
            #pragma warning disable BL0005
            __typeInference_CreateTestComponent_0.
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                  Parameter

#line default
#line hidden
#nullable disable
             = default;
            #pragma warning restore BL0005
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.TestComponent<>);

#line default
#line hidden
#nullable disable
            var __typeInference_CreateTestComponent_1 = global::__Blazor.Test.TestComponent.TypeInference.CreateTestComponent_1(__builder, -1, -1, "", -1, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                        () => { }

#line default
#line hidden
#nullable disable
            ), -1, 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                "named-form-handler"

#line default
#line hidden
#nullable disable
            , -1, 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                                  2

#line default
#line hidden
#nullable disable
            );
            #pragma warning disable BL0005
            __typeInference_CreateTestComponent_1.
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                       Parameter

#line default
#line hidden
#nullable disable
             = default;
            #pragma warning restore BL0005
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.TestComponent<>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter] public T Parameter { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static global::Test.TestComponent<T> CreateTestComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::Test.TestComponent<T>>(seq);
        __builder.AddAttribute(__seq0, "method", (object)__arg0);
        __builder.AddAttribute(__seq1, "onsubmit", (object)__arg1);
        __builder.AddAttribute(__seq2, "@formname", (object)__arg2);
        __builder.AddAttribute(__seq3, "Parameter", (object)__arg3);
        __builder.CloseComponent();
        return default;
        }
        public static global::Test.TestComponent<T> CreateTestComponent_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::Test.TestComponent<T>>(seq);
        __builder.AddAttribute(__seq0, "method", (object)__arg0);
        __builder.AddAttribute(__seq1, "onsubmit", (object)__arg1);
        __builder.AddAttribute(__seq2, "@formname", (object)__arg2);
        __builder.AddAttribute(__seq3, "Parameter", (object)__arg3);
        __builder.CloseComponent();
        return default;
        }
    }
}
#pragma warning restore 1591