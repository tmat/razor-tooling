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
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "method", "post");
            __builder.AddAttribute(2, "onsubmit", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line (2,32)-(2,41) "x:\dir\subdir\Test\TestComponent.cshtml"
() => { }

#line default
#line hidden
#nullable disable
            ));
            string __formName = global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>("start" + " " + (
#nullable restore
#line (2,62)-(2,71) "x:\dir\subdir\Test\TestComponent.cshtml"
"literal"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line (2,74)-(2,75) "x:\dir\subdir\Test\TestComponent.cshtml"
x

#line default
#line hidden
#nullable disable
            ) + " end");
            __builder.AddNamedEvent("onsubmit", __formName);
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (3,8)-(5,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    int x = 1;

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591