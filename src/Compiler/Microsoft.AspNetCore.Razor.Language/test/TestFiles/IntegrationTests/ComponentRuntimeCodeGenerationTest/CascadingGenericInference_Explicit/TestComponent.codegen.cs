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
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.Grid<DateTime>>(0);
            __builder.AddAttribute(1, "Items", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<DateTime>>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                Array.Empty<DateTime>()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                global::__Blazor.Test.TestComponent.TypeInference.CreateColumn_0(__builder2, 3, default(DateTime));
                global::__Blazor.Test.TestComponent.TypeInference.CreateColumn_1(__builder2, 4, default(DateTime));
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TItem __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TItem __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
