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
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line (2,19)-(2,36) "x:\dir\subdir\Test\TestComponent.cshtml"
() => Foo = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(2, "onfocus", 
#nullable restore
#line (2,63)-(2,67) "x:\dir\subdir\Test\TestComponent.cshtml"
true

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(3, "onclick", 
#nullable restore
#line (2,95)-(2,98) "x:\dir\subdir\Test\TestComponent.cshtml"
Foo

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(4, "onfocus", 
#nullable restore
#line (2,126)-(2,131) "x:\dir\subdir\Test\TestComponent.cshtml"
false

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Click Me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (3,8)-(5,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    bool Foo { get; set; }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591