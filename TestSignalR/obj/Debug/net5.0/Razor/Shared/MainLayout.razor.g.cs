#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8493abfa325be23c81b83f4bd8de843f353bac"
// <auto-generated/>
#pragma warning disable 1591
namespace TradingPlatformBlazor.Shared
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
    public partial class MainLayout : LayoutComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "main");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "nav");
                __builder2.AddAttribute(7, "class", "navbar navbar-expand-lg navbar-light border");
                __builder2.AddMarkupContent(8, "<a class=\"navbar-brand\" href=\"/\"><img src=\"img/resources/logo.svg\" width=\"140\" height=\"30\" alt></a>\r\n                    ");
                __builder2.AddMarkupContent(9, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarToggler"" aria-controls=""navbarToggler"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
                    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "collapse navbar-collapse ");
                __builder2.AddAttribute(12, "id", "navbarToggler");
                __builder2.OpenElement(13, "ul");
                __builder2.AddAttribute(14, "class", "navbar-nav  mb-2 mb-lg-0 ms-auto");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(15);
                __builder2.AddAttribute(16, "Roles", "Administrator");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((any) => (__builder3) => {
                    __builder3.AddMarkupContent(18, "<li class=\"nav-item content-pos\"><a href=\"/admin\"><span class=\"oi oi-browser\" alt=\"AdminPanel\"></span></a></li>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                             if (user.IdShop != 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item content-pos");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "/shop/" + (
#nullable restore
#line 56 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                                    ShopUrl(user.IdShop)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "<span class=\"oi oi-briefcase\" alt=\"Buisnes\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 58 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                             if (user.LevelUser == UserLevel.Third && user.IdShop == 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(24, "<li class=\"nav-item content-pos\"><a href=\"/createshop\"><span class=\"oi oi-briefcase\" alt=\"Buisnes\"></span></a></li>");
#nullable restore
#line 64 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(25, "<li class=\"nav-item content-pos\"><a href=\"/purchases\"><span class=\"oi oi-cart\" alt=\"??????????????\"></span></a></li>\r\n                            ");
                __builder2.AddMarkupContent(26, "<li class=\"nav-item content-pos\"><a href=\"/sales\"><span class=\"oi oi-transfer\" alt=\"??????????????\"></span></a></li>\r\n                            ");
                __builder2.AddMarkupContent(27, "<li class=\"nav-item content-pos\"><a href=\"/messager\"><span class=\"oi oi-chat\" alt=\"Messeger\"></span></a></li>\r\n                            ");
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "class", "nav-item");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "balance-user");
#nullable restore
#line 75 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
__builder2.AddContent(32, user.Balance);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "move-block");
                __builder2.AddMarkupContent(36, "<a class=\"a-logout content-pos\" href=\"/logout\"><span class=\"oi oi-account-logout\"></span></a>\r\n                            ");
                __builder2.OpenElement(37, "a");
                __builder2.AddAttribute(38, "href", "/user/" + (
#nullable restore
#line 81 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                            user.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "target", "_top");
                __builder2.OpenElement(40, "img");
                __builder2.AddAttribute(41, "class", "user-img-top");
                __builder2.AddAttribute(42, "src", "/img/avatars/" + (
#nullable restore
#line 81 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                                                                                                user.PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(43, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(44, @"<nav class=""navbar navbar-expand-lg navbar-light d-flex border""><div class=""container-fluid""><a class=""navbar-brand"" href=""/""><img src=""img/resources/logo.svg"" width=""140"" height=""30"" alt></a>
                        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarToggler"" aria-controls=""navbarToggler"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
                        <div class=""collapse navbar-collapse "" id=""navbarToggler""><ul class=""navbar-nav  mb-2 mb-lg-0 ms-auto  ""><li class=""nav-item""><a class=""nav-link active"" aria-current=""page"" href=""/signup"">Sign up</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""/signin"">Sign in</a></li></ul></div></div></nav>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "content px-4");
#nullable restore
#line 121 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
__builder.AddContent(48, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.AddMarkupContent(50, @"<footer id=""footer""><div class=""footer-line""></div>
    <div class=""footer-content""><div class=""row""><div class=""col justify-content-start""><div class=""footer-content-item d-inline-block""><p class=""copyright "">&#169; 2021-2022 TradingPlatform</p></div>
                <div class=""footer-content-item d-inline-block""><a href=""/terms"">???????????????????????????????? ????????????????????</a></div>
                <div class=""footer-content-item d-inline-block""><a href=""/about"">?? ??????????????</a></div></div>
        
            <div class=""col-4 revers-content""><div class=""footer-content-item d-inline-block""><a href=""https://github.com/xoathx/TradingPlatformBlazor""><span class=""oi oi-cloud""></span></a></div></div></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
      
        [Inject] IHttpContextAccessor htp { get; set; }
        HubConnection hubConnection;

        User user;
    protected override async Task OnInitializedAsync()
    {
        if (htp.HttpContext.User.Claims.Any())
        {
            user = SqlUser.GetUserById(int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value));
            hubConnection = new HubConnectionBuilder()
      .WithUrl(Navigation.ToAbsoluteUri("/hub"), opt =>
      {
          if (htp.HttpContext.Request.Cookies.Count > 0)
          {
              opt.Cookies.Add(new Uri(Navigation.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
          }
      }).Build();

            hubConnection.On<Message>("ReceiveMessage", (mess) =>
            {


                StateHasChanged();

            });
            await hubConnection.StartAsync();
        }

    }

    public void Dispose()
    {
        if (hubConnection != null)
        {
            hubConnection.DisposeAsync();
        }
    }
    public async ValueTask DisposeAsync()
    {
        if (hubConnection != null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    string ShopUrl(int shopId)
    {
        return SqlShop.GetShopById(shopId).ShortNameShop;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShop SqlShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
