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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "myvalue", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line (1,20)-(1,31) "x:\dir\subdir\Test\TestComponent.cshtml"
ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "anotherevent", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ParentValue = __value, ParentValue));
            __builder.SetUpdatesAttributeName("myvalue");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (2,8)-(4,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    public string ParentValue { get; set; } = "hi";

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591