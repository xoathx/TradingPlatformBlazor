#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c952b2134e0b5f56745b96387d30a08e46f20a"
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
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using TradingPlatformBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchases")]
    public partial class PagePurchases : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3>PagePurchases</h3>\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "sales-content");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container");
                __builder2.AddMarkupContent(7, @"<div class=""row""><div class=""col"">Дата</div>
                    <div class=""col"">Номер заказа</div>
                    <div class=""col-2"">Описание</div>
                    <div class=""col"">Продавец</div>
                    <div class=""col"">Статус</div>
                    <div class=""col"">Сумма</div></div>");
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                 foreach (var item in Offers)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "a");
                __builder2.AddAttribute(9, "class", "a-pagesales");
                __builder2.AddAttribute(10, "href", "/offer/" + (
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                         item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row border content-body-sales");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col border-right");
                __builder2.OpenElement(15, "p");
                __builder2.AddContent(16, 
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                              item.DateClosing.ToString("D")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col border-right");
                __builder2.OpenElement(20, "p");
                __builder2.AddContent(21, "#");
                __builder2.AddContent(22, 
#nullable restore
#line 24 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                               item.IdentifierName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-2 border-right desc-offer-sales");
                __builder2.OpenElement(26, "p");
                __builder2.AddContent(27, 
#nullable restore
#line 25 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                                                 item.LotsDesc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col border-right vendor-info-pagepurchases d-inline");
                __builder2.OpenElement(31, "a");
                __builder2.AddAttribute(32, "class", "a-pagesales");
                __builder2.AddAttribute(33, "href", "/user/" + (
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                                    item.VendorId

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(34, "img");
                __builder2.AddAttribute(35, "class", "avatar avatar-customer-pagesales");
                __builder2.AddAttribute(36, "src", "img/avatars/" + (
#nullable restore
#line 28 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                                                                    SqlUser.GetUserById(item.VendorId).PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "nickname-customer-pagesales");
                __builder2.AddContent(40, 
#nullable restore
#line 29 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                                              SqlUser.GetUserById(item.VendorId).NickName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col border-right");
                __builder2.OpenElement(44, "p");
                __builder2.AddContent(45, 
#nullable restore
#line 32 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                              StateCurOffer(item.StateOffer)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col");
                __builder2.OpenElement(49, "p");
                __builder2.AddContent(50, 
#nullable restore
#line 33 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                                                 item.LotsPrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PagePurchases.razor"
           
        private IEnumerable<Offer> Offers;
        private int CurrentUserId;
        private string State;

        protected override void OnInitialized()
        {
            if (htp.HttpContext.User.Claims.Count() > 0)
            {
                CurrentUserId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
                Offers = SqlOffer.GetOffersByCustonerId(CurrentUserId).ToList();
            }
        }

        string StateCurOffer(StateOffer state)
        {
            switch (state)
            {
                case StateOffer.Canceled:
                    State = "Отменен";
                    break;
                case StateOffer.InProcess:
                    State = "В процессе";
                    break;
                case StateOffer.Completed:
                    State = "Завершен";
                    break;
                case StateOffer.ManyBack:
                    State = "Возврат";
                    break;
                default:
                    State = state.ToString();
                    break;
            }
            return State;
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IOffer SqlOffer { get; set; }
    }
}
#pragma warning restore 1591
