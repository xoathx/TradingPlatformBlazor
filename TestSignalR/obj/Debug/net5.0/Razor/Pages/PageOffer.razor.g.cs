#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f941127066209c7e4e6544bde03e59cd2db3aaa7"
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
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/offer/{IdOffer:int}")]
    public partial class PageOffer : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                     globalRoles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((any) => (__builder2) => {
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
     if (currentOffer == null)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, 
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
      message

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
              }
else
{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col");
                __builder2.OpenElement(10, "h1");
                __builder2.AddMarkupContent(11, "Заказ #");
                __builder2.AddContent(12, 
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                            currentOffer.IdentifierName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                 if (currentOffer.StateOffer == StateOffer.Completed)
                {
                    selectorState = "completedOffer";
                    messageState = "Завершено";
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                 if (currentOffer.StateOffer == StateOffer.Canceled)
                {
                    selectorState = "canseledOffer";
                    messageState = "Отменен";
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                 if (currentOffer.StateOffer == StateOffer.InProcess)
                {
                    messageState = "В процессе...";
                    selectorState = "inprocessOffer";
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                 if (currentOffer.StateOffer == StateOffer.ManyBack)
                {
                    selectorState = "manybackOffer";
                    messageState = "Возврат";
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "h4");
                __builder2.AddAttribute(14, "class", 
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                            selectorState

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(15, 
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                            messageState

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "nameLot");
                __builder2.OpenElement(19, "p");
                __builder2.AddAttribute(20, "class", "h3");
                __builder2.AddContent(21, 
#nullable restore
#line 41 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                    currentOffer.LotsName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                <hr align=\"left\" width=\"500px\" color=\"#80CEFD\">\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "descpLot");
                __builder2.OpenElement(25, "p");
                __builder2.AddContent(26, 
#nullable restore
#line 44 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                        currentOffer.LotsDesc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                <hr align=\"left\" width=\"500px\" color=\"#80CEFD\">\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "priceOffer");
                __builder2.OpenElement(30, "p");
                __builder2.AddContent(31, 
#nullable restore
#line 48 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                        currentOffer.LotsPrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.AddMarkupContent(33, "<div class=\"payState\">Оплачено</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "panelButOffer");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(37);
                __builder2.AddAttribute(38, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                           SqlUser.GetUserById(currentOffer.CustomerId).NickName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                         if (currentOffer.StateOffer == StateOffer.InProcess)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(40, "button");
                    __builder3.AddAttribute(41, "class", "btn btn-success");
                    __builder3.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                      CustomerCompletedOffer

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(43, "Завершить заказ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n                            ");
                    __builder3.OpenElement(45, "button");
                    __builder3.AddAttribute(46, "class", "btn btn-danger");
                    __builder3.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                     CustomerCanseledOffer

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(48, "Отменить заказ");
                    __builder3.CloseElement();
#nullable restore
#line 57 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                         if (currentOffer.StateOffer == StateOffer.Completed)
                        {
                            if(currentOffer.IsCommented == true) { } else { 

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(49, "button");
                    __builder3.AddAttribute(50, "class", "btn btn-light");
                    __builder3.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                    OnDialogOpen

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(52, "Оставить отзыв");
                    __builder3.CloseElement();
#nullable restore
#line 61 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                                                         }
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 64 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                     if(VendorShop != null) 
                    { 

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(53);
                __builder2.AddAttribute(54, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                           GetGlobalRoles(MembersShop)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
#nullable restore
#line 67 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                         if (currentOffer.StateOffer != StateOffer.Completed && currentOffer.IsManyBack == false)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(56, "button");
                    __builder3.AddAttribute(57, "class", "btn btn-light");
                    __builder3.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                    ManyBack

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(59, "Вернуть деньги");
                    __builder3.CloseElement();
#nullable restore
#line 70 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "comment-offer");
#nullable restore
#line 75 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                     if (Comment != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "row border comment-body");
                __builder2.OpenElement(65, "a");
                __builder2.AddAttribute(66, "href", "/user/" + (
#nullable restore
#line 79 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                            Comment.FromUserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "target", "_top");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col nickname-comment-user ");
                __builder2.OpenElement(70, "img");
                __builder2.AddAttribute(71, "class", "avatar d-inline avatar-comment-user");
                __builder2.AddAttribute(72, "src", "/img/avatars/" + (
#nullable restore
#line 81 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                                                        SqlUser.GetUserById(Comment.FromUserId).PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                    ");
                __builder2.AddContent(74, 
#nullable restore
#line 82 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                     SqlUser.GetUserById(Comment.FromUserId).NickName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-6 col-sm-3 bodytext-comment-user");
                __builder2.OpenElement(78, "p");
                __builder2.AddContent(79, 
#nullable restore
#line 86 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                    Comment.BodyComment

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "rating-mini rating-comment-user");
#nullable restore
#line 90 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                     for (int i = 1; i <= 5; i++)
                                    {
                                        if (i <= Comment.ValueRating)
                                        {
                                            selector = "active";

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(85, "span");
                __builder2.AddAttribute(86, "class", 
#nullable restore
#line 95 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                          selector

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 96 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(87, "<span></span>");
#nullable restore
#line 100 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 106 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "offerChat");
#nullable restore
#line 112 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                     if(currentOffer.ShopLotId == 0 && currentOffer.VendorShopId == 0)
                    { 

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(93);
                __builder2.AddAttribute(94, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 114 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                           Customer.NickName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<TradingPlatformBlazor.Shared.Chat>(96);
                    __builder3.AddAttribute(97, "ToUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 115 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                        currentOffer.VendorId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(99);
                __builder2.AddAttribute(100, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 117 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                           Vendor.NickName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<TradingPlatformBlazor.Shared.Chat>(102);
                    __builder3.AddAttribute(103, "ToUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 118 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                        currentOffer.CustomerId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 120 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 125 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
     if(OpenDialog) {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<TradingPlatformBlazor.Shared.AddComment>(104);
                __builder2.AddAttribute(105, "CurrentOffer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TradingPlatformBlazor.Data.Models.Offer>(
#nullable restore
#line 125 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                currentOffer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 125 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                       OnDialogClose

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 125 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
                                                                                                     
}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
       
    [Parameter]
    public int IdOffer { get; set; }
    HubConnection hubConnection;
    private Offer currentOffer;
    string message;
    private string messageState = "В процессе...";
    private string selectorState = "inprocessOffer";
    private string currentUserName;
    private string globalRoles;
    private string selector;
    private int customerId;
    private User Vendor;
    private User Customer;
    private Comment Comment;
    private Shop VendorShop;
    IEnumerable<User> MembersShop = new List<User>();
    private bool OpenDialog { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentOffer = SqlOffer.GetOfferById(IdOffer);
        if (currentOffer == null)
        {
            message = "Страница не найдена.";
        }
        else
        {
            if(currentOffer.ShopLotId == 0 && currentOffer.VendorShopId == 0)
            {
                Customer = SqlUser.GetUserById(currentOffer.CustomerId);
                Vendor = SqlUser.GetUserById(currentOffer.VendorId);
                Comment = SqlComment.GetCommentByOfferId(currentOffer.Id);
                currentUserName = htp.HttpContext.User.Identity.Name;
                customerId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
                globalRoles = SqlUser.GetUserById(currentOffer.CustomerId).NickName + ", " + SqlUser.GetUserById(currentOffer.VendorId).NickName;
            }
            else
            {
                Customer = SqlUser.GetUserById(currentOffer.CustomerId);
                VendorShop = SqlShop.GetShopById(currentOffer.VendorShopId);
                Comment = SqlComment.GetCommentByOfferId(currentOffer.Id);
                currentUserName = htp.HttpContext.User.Identity.Name;
                customerId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
                MembersShop = SqlUser.GetShopMembersByShopId(VendorShop.Id);
                globalRoles = GetGlobalRoles(MembersShop) + Customer.NickName;
            }
        }
        hubConnection = new HubConnectionBuilder()
  .WithUrl(nav.ToAbsoluteUri("/hub"), opt =>
  {
      if (htp.HttpContext.Request.Cookies.Count > 0)
      {
          opt.Cookies.Add(new Uri(nav.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
      }
  }).Build();
        hubConnection.On<UpdateOffer>("UpdatingOffer", (update) =>
        {
            if (update.StateOffer == StateOffer.Canceled)
            {
                CanseledOffer();
                StateHasChanged();
            }
            if (update.StateOffer == StateOffer.Completed)
            {
                CompletedOffer();
                StateHasChanged();
            }
        });
        await hubConnection.StartAsync();
    }

    void CompletedOffer()
    {
        selectorState = "completedOffer";
        messageState = "Завершено";
        currentOffer.IsOpenned = false;
        currentOffer.DateClosing = DateTime.Now;
        currentOffer.StateOffer = StateOffer.Completed;

        SqlOffer.UpdateOffer(currentOffer);
        SqlLot.DeleteLot(SqlLot.GetLotByID(currentOffer.LotId));

        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }
    void CanseledOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        currentOffer.StateOffer = StateOffer.Canceled;
        currentOffer.IsOpenned = false;
        SqlUser.ManyBack(currentOffer.CustomerId, currentOffer.LotsPrice);
        currentOffer.IsManyBack = true;
        SqlOffer.UpdateOffer(currentOffer);
        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }

    void ManyBack()
    {
        selectorState = "manybackOffer";
        messageState = "Возврат";
        currentOffer.StateOffer = StateOffer.ManyBack;
        currentOffer.IsOpenned = false;
        SqlUser.ManyBack(currentOffer.CustomerId, currentOffer.LotsPrice);
        currentOffer.IsManyBack = true;

        SqlOffer.UpdateOffer(currentOffer);
        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }
    async Task CustomerCompletedOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        UpdateOffer updateOffer = new UpdateOffer()
        {
            UserId = currentOffer.VendorId,
            StateOffer = StateOffer.Completed
        };
        await hubConnection.SendAsync("UpdateOffer", updateOffer);
        StateHasChanged();
    }
    async Task CustomerCanseledOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        UpdateOffer updateOffer = new UpdateOffer()
        {
            UserId = currentOffer.VendorId,
            StateOffer = StateOffer.Canceled
        };
        await hubConnection.SendAsync("UpdateOffer", updateOffer);
        StateHasChanged();
    }

    private void OnDialogClose()
    {
        OpenDialog = false;
    }
    private void OnDialogOpen()
    {
        OpenDialog = true;
    }
    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    private string GetGlobalRoles(IEnumerable<User> members)
    {
        string result = string.Empty;
        foreach(var item in members)
            {
                result += item.NickName + ",";
            }
        return result;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShop SqlShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IComment SqlComment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IOffer SqlOffer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
