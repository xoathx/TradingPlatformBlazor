#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff610447c37e880d0873261bd6a803566bd0e080"
// <auto-generated/>
#pragma warning disable 1591
namespace TradingPlatformBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lots/{id:int}")]
    public partial class CategoysLots : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "name-category");
            __builder.AddAttribute(2, "b-izu0hnn6a8");
#nullable restore
#line 8 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(3, nameCategory);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "block-addlot");
                __builder2.AddAttribute(9, "b-izu0hnn6a8");
                __builder2.AddMarkupContent(10, "<label class=\"addlot\" for=\"button-addlot\" b-izu0hnn6a8><span class=\"oi oi-plus\" b-izu0hnn6a8></span></label>\r\n            ");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "id", "button-addlot");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                                                 OpenDialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "b-izu0hnn6a8");
                __builder2.AddMarkupContent(15, "???????????????? ??????");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddAttribute(19, "b-izu0hnn6a8");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col");
            __builder.AddAttribute(22, "b-izu0hnn6a8");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "content-categorylots");
            __builder.AddAttribute(25, "b-izu0hnn6a8");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "container");
            __builder.AddAttribute(28, "b-izu0hnn6a8");
            __builder.AddMarkupContent(29, @"<div class=""row"" b-izu0hnn6a8><div class=""col border-right name-lot-categorylots"" b-izu0hnn6a8>???????????????? ????????</div>
                    <div class=""col-6 border-right desc-lot-categorylots"" b-izu0hnn6a8>???????????????? ????????</div>
                    <div class=""col price-lot-categorylots"" b-izu0hnn6a8>????????</div></div>");
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                 foreach (var lot in allLots)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "a-lot-categorylots");
            __builder.AddAttribute(32, "href", "/lot/" + (
#nullable restore
#line 33 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                                                              lot.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "b-izu0hnn6a8");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row border body-lot-categorylots");
            __builder.AddAttribute(36, "b-izu0hnn6a8");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col border-right  name-lot-categorylots");
            __builder.AddAttribute(39, "b-izu0hnn6a8");
#nullable restore
#line 35 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(40, lot.NameLot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-6 border-right desc-lot-categorylots");
            __builder.AddAttribute(44, "b-izu0hnn6a8");
#nullable restore
#line 36 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(45, MiniString(lot.DescLot));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col price-lot-categorylots");
            __builder.AddAttribute(49, "b-izu0hnn6a8");
#nullable restore
#line 37 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(50, lot.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col");
            __builder.AddAttribute(54, "b-izu0hnn6a8");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "content-categorylots");
            __builder.AddAttribute(57, "b-izu0hnn6a8");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "container");
            __builder.AddAttribute(60, "b-izu0hnn6a8");
            __builder.AddMarkupContent(61, @"<div class=""row"" b-izu0hnn6a8><div class=""col border-right name-lot-categorylots"" b-izu0hnn6a8>???????????????? ????????</div>
                    <div class=""col-6 border-right desc-lot-categorylots"" b-izu0hnn6a8>???????????????? ????????</div>
                    <div class=""col price-lot-categorylots"" b-izu0hnn6a8>????????</div></div>");
#nullable restore
#line 54 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                 foreach (var lot in allShopLots)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "a-lot-categorylots");
            __builder.AddAttribute(64, "href", "/shoplot/" + (
#nullable restore
#line 57 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                                                                  lot.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "b-izu0hnn6a8");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row border body-lot-categorylots");
            __builder.AddAttribute(68, "b-izu0hnn6a8");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col border-right  name-lot-categorylots");
            __builder.AddAttribute(71, "b-izu0hnn6a8");
#nullable restore
#line 59 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(72, lot.NameLot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-6 border-right desc-lot-categorylots");
            __builder.AddAttribute(76, "b-izu0hnn6a8");
#nullable restore
#line 60 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(77, MiniString(lot.DescLot));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col price-lot-categorylots");
            __builder.AddAttribute(81, "b-izu0hnn6a8");
#nullable restore
#line 61 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
__builder.AddContent(82, lot.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
 if (DialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TradingPlatformBlazor.Shared.AddLots>(83);
            __builder.AddAttribute(84, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                     nameCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                                            OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(86, "CategoryId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
                                                                        Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 73 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\CategoysLots.razor"
       
    [Parameter]
    public int Id { get; set; }

    private string nameCategory;
    IEnumerable<Lot> allLots = new List<Lot>();
    public bool DialogOpen { get; set; }

    IEnumerable<ShopLot> allShopLots = new List<ShopLot>();

    protected override async Task OnInitializedAsync()
    {
        nameCategory = SqlCategory.AllCategories().First(c => c.Id == Id).NameCategory;
        allLots = SqlLot.LotsByID(Id).ToList();

        allShopLots = SqlShopLot.ShopLotsByCategoryId(Id).ToList();
        await JSRuntime.InvokeVoidAsync("setTitle", nameCategory);
    }


    private void OnDialogClose()
    {
        allLots = SqlLot.LotsByID(Id).ToList();

        allShopLots = SqlShopLot.ShopLotsByCategoryId(Id).ToList();
        DialogOpen = false;


    }
    private void OpenDialog()
    {
        DialogOpen = true;
    }

    string MiniString(string str)
    {
        if (string.IsNullOrWhiteSpace(str)) { return str; }
        else
        {
            if (str.Length > 50)
            {
                return new string(str.Substring(0, 50) + "...");
            }
            return str;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShopLot SqlShopLot { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ICategory SqlCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
    }
}
#pragma warning restore 1591
