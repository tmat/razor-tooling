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
#line (1,2)-(2,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Web

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class TestComponent<
#nullable restore
#line (2,12)-(2,13) "x:\dir\subdir\Test\TestComponent.cshtml"
T

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.Test.TestComponent.TypeInference.CreateTestComponent_0(__builder, 0, 1, "post", 2, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line (3,41)-(3,50) "x:\dir\subdir\Test\TestComponent.cshtml"
() => { }

#line default
#line hidden
#nullable disable
            ), 3, "named-form-handler", 4, 
#nullable restore
#line (3,94)-(3,95) "x:\dir\subdir\Test\TestComponent.cshtml"
1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            global::__Blazor.Test.TestComponent.TypeInference.CreateTestComponent_1(__builder, 6, 7, "post", 8, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line (4,41)-(4,50) "x:\dir\subdir\Test\TestComponent.cshtml"
() => { }

#line default
#line hidden
#nullable disable
            ), 9, 
#nullable restore
#line (4,65)-(4,85) "x:\dir\subdir\Test\TestComponent.cshtml"
"named-form-handler"

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line (4,99)-(4,100) "x:\dir\subdir\Test\TestComponent.cshtml"
2

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line (5,8)-(7,1) "x:\dir\subdir\Test\TestComponent.cshtml"

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
        public static void CreateTestComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::Test.TestComponent<T>>(seq);
        __builder.AddComponentParameter(__seq0, "method", __arg0);
        __builder.AddComponentParameter(__seq1, "onsubmit", __arg1);
        __builder.AddComponentParameter(__seq2, "@formname", __arg2);
        __builder.AddComponentParameter(__seq3, "Parameter", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateTestComponent_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::Test.TestComponent<T>>(seq);
        __builder.AddComponentParameter(__seq0, "method", __arg0);
        __builder.AddComponentParameter(__seq1, "onsubmit", __arg1);
        __builder.AddComponentParameter(__seq2, "@formname", __arg2);
        __builder.AddComponentParameter(__seq3, "Parameter", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591