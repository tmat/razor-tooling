﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Test;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            var __typeInference_CreateMyComponent_0 = global::__Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(__builder, -1, -1, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                        1

#line default
#line hidden
#nullable disable
            );
            __o = __typeInference_CreateMyComponent_0.
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
             Parameter

#line default
#line hidden
#nullable disable
            ;
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.MyComponent<>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static global::Test.MyComponent<T> CreateMyComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
            where T : unmanaged
        {
        __builder.OpenComponent<global::Test.MyComponent<T>>(seq);
        __builder.AddAttribute(__seq0, "Parameter", __arg0);
        __builder.CloseComponent();
        return default;
        }
    }
}
#pragma warning restore 1591
