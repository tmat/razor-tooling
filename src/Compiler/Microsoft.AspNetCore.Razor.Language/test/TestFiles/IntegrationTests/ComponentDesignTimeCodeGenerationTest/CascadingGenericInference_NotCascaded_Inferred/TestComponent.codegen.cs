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
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            {
                global::__Blazor.Test.TestComponent.TypeInference.CreateGrid_0_CaptureParameters(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
               Array.Empty<DateTime>()

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0);
                var __typeInference_CreateGrid_0 = global::__Blazor.Test.TestComponent.TypeInference.CreateGrid_0(__builder, -1, -1, __typeInferenceArg_0___arg0, -1, (__builder2) => {
                    var __typeInference_CreateColumn_1 = global::__Blazor.Test.TestComponent.TypeInference.CreateColumn_1(__builder2, -1, __typeInferenceArg_0___arg0);
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.Column<>);

#line default
#line hidden
#nullable disable
                    var __typeInference_CreateColumn_2 = global::__Blazor.Test.TestComponent.TypeInference.CreateColumn_2(__builder2, -1, __typeInferenceArg_0___arg0);
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.Column<>);

#line default
#line hidden
#nullable disable
                }
                );
                #pragma warning disable BL0005
                __typeInference_CreateGrid_0.
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
      Items

#line default
#line hidden
#nullable disable
                 = default;
                #pragma warning restore BL0005
            }
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.Grid<>);

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
        public static global::Test.Grid<TItem> CreateGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Test.Grid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        return default;
        }

        public static void CreateGrid_0_CaptureParameters<TItem>(global::System.Collections.Generic.IEnumerable<TItem> __arg0, out global::System.Collections.Generic.IEnumerable<TItem> __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static global::Test.Column<TItem> CreateColumn_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, global::System.Collections.Generic.IEnumerable<TItem> __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.CloseComponent();
        return default;
        }
        public static global::Test.Column<TItem> CreateColumn_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, global::System.Collections.Generic.IEnumerable<TItem> __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.Column<TItem>>(seq);
        __builder.CloseComponent();
        return default;
        }
    }
}
#pragma warning restore 1591