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
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "onfocus", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line (2,18)-(2,25) "x:\dir\subdir\Test\TestComponent.cshtml"
OnFocus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(2, "onfocus", 
#nullable restore
#line (2,52)-(2,74) "x:\dir\subdir\Test\TestComponent.cshtml"
ShouldPreventDefault()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (3,8)-(7,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    void OnFocus(FocusEventArgs e) { }

    bool ShouldPreventDefault() { return false; }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591