#pragma checksum "E:\Ecep\Toko\Toko\TokoApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c553f727700d99064cdf20801ff725c1c4eb144"
// <auto-generated/>
#pragma warning disable 1591
namespace TokoApp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "sidebar");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<TokoApp.Shared.NavMenu>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "main");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "top-row px-4");
            __builder.AddAttribute(19, "style", "justify-content:flex-start");
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(21);
            __builder.AddAttribute(22, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\Ecep\Toko\Toko\TokoApp\Shared\MainLayout.razor"
                           AppState.ComponentTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Style", "font-weight:bold;font-size:28px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    \r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "content px-4");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddContent(29, 
#nullable restore
#line 26 "E:\Ecep\Toko\Toko\TokoApp\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\Ecep\Toko\Toko\TokoApp\Shared\MainLayout.razor"
      
    protected override void OnInitialized()
    {
        AppState.OnChangeComponentTitle += StateHasChanged;
        

    }

    public void Dispose()
    {
        AppState.OnChangeComponentTitle -= StateHasChanged;
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591
