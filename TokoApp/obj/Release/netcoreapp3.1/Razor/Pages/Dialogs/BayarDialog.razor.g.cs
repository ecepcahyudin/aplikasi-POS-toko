#pragma checksum "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa9689054f5233702f46e4d0871466124b08165"
// <auto-generated/>
#pragma warning disable 1591
namespace TokoApp.Pages.Dialogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using TokoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using TokoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Ecep\Toko\Toko\TokoApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class BayarDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-5");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(12);
            __builder.AddAttribute(13, "Text", "Jumlah Harus Dibayar");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-7");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(19);
            __builder.AddAttribute(20, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                                        String.Format(new System.Globalization.CultureInfo("id-ID"), "{0:C}",JmlHarudDibayar)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", "font-weight:bold");
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-5");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(32);
            __builder.AddAttribute(33, "Text", "Jumlah Uang Diterima");
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-md-7");
            __builder.AddMarkupContent(38, "\r\n                ");
            __Blazor.TokoApp.Pages.Dialogs.BayarDialog.TypeInference.CreateRadzenNumeric_0(__builder, 39, 40, "font-weight:bold", 41, 
#nullable restore
#line 26 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                             JmlDiterima

#line default
#line hidden
#nullable disable
            , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => JmlDiterima = __value, JmlDiterima)), 43, () => JmlDiterima);
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-md-5");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
            __builder.AddAttribute(54, "Text", "Kembalian");
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-7");
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(60);
            __builder.AddAttribute(61, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "style", "font-weight:bold");
            __builder.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                             Kembalian

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Kembalian = __value, Kembalian))));
            __builder.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Kembalian));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-md-12");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(77);
            __builder.AddAttribute(78, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                               (args) => dialogService.Close(true)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(79, "Text", "OK");
            __builder.AddAttribute(80, "Style", "margin-bottom: 10px; width: 150px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(82);
            __builder.AddAttribute(83, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                               (args) => dialogService.Close(false)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(84, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 50 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
                                                                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "Text", "Cancel");
            __builder.AddAttribute(86, "Style", "margin-bottom: 10px; width: 150px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\Ecep\Toko\Toko\TokoApp\Pages\Dialogs\BayarDialog.razor"
       
    [Parameter] public int JmlHarudDibayar { get; set; }

    private int JmlDiterima { get; set; }

    private string Kembalian {

        get {
            return String.Format(new CultureInfo("id-ID"), "{0:C}", (JmlDiterima- JmlHarudDibayar)<0?0:(JmlDiterima - JmlHarudDibayar));
        }

        set
        {

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Radzen.DialogService dialogService { get; set; }
    }
}
namespace __Blazor.TokoApp.Pages.Dialogs.BayarDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
