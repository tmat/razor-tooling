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
            global::__Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(__builder, 0, 1, 
#nullable restore
#line (1,31)-(1,42) "x:\dir\subdir\Test\TestComponent.cshtml"
ParentValue

#line default
#line hidden
#nullable disable
            , 2, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ParentValue = __value, ParentValue)), 3, () => ParentValue);
        }
        #pragma warning restore 1998
#nullable restore
#line (2,8)-(4,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    public DateTime ParentValue { get; set; } = DateTime.Now;

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
        public static void CreateMyComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2)
        {
        __builder.OpenComponent<global::Test.MyComponent<T>>(seq);
        __builder.AddComponentParameter(__seq0, "SomeParam", __arg0);
        __builder.AddComponentParameter(__seq1, "SomeParamChanged", __arg1);
        __builder.AddComponentParameter(__seq2, "SomeParamExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591