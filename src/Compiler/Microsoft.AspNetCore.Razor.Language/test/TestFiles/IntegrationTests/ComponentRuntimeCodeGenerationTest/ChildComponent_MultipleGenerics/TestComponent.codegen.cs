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
    #line default
    #line hidden
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.MyComponent<string, int>>(0);
            __builder.AddComponentParameter(1, "Item", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line (1,47)-(1,51) "x:\dir\subdir\Test\TestComponent.cshtml"
"hi"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<string>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddContent(4, 
#nullable restore
#line (2,23)-(2,40) "x:\dir\subdir\Test\TestComponent.cshtml"
context.ToLower()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(5, "AnotherChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Test.MyComponent<string, int>.Context>)((item) => (__builder2) => {
                __builder2.AddContent(6, 
#nullable restore
#line (4,4)-(4,33) "x:\dir\subdir\Test\TestComponent.cshtml"
System.Math.Max(0, item.Item)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, ";\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591