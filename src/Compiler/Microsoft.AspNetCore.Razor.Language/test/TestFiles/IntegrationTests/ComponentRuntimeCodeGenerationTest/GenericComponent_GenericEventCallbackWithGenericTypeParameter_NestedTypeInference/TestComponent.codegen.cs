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
#line (2,2)-(3,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Test

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class TestComponent<
#nullable restore
#line (1,12)-(1,18) "x:\dir\subdir\Test\TestComponent.cshtml"
TChild

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(__builder, 0, 1, 
#nullable restore
#line (3,20)-(3,29) "x:\dir\subdir\Test\TestComponent.cshtml"
ChildItem

#line default
#line hidden
#nullable disable
            , 2, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line (3,40)-(3,52) "x:\dir\subdir\Test\TestComponent.cshtml"
MyChildEvent

#line default
#line hidden
#nullable disable
            ));
        }
        #pragma warning restore 1998
#nullable restore
#line (5,2)-(8,1) "x:\dir\subdir\Test\TestComponent.cshtml"

        [Parameter] public TChild ChildItem { get; set; }
        [Parameter] public EventCallback<TChild> MyChildEvent { get; set; }

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
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg1)
        {
        __builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        __builder.AddComponentParameter(__seq0, "Item", __arg0);
        __builder.AddComponentParameter(__seq1, "MyEvent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591