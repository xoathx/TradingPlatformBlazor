#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fef68cc374bab9da4ca34bb1a422d6b0891129"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-8igy2qtvpp");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-8igy2qtvpp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "top-row px-4");
                __builder2.AddAttribute(10, "b-8igy2qtvpp");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
                __builder2.AddAttribute(12, "Roles", "Administrator");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((any) => (__builder3) => {
                    __builder3.AddMarkupContent(14, "<a href=\"/add_category\" b-8igy2qtvpp>Админ-панель</a>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                     if (user.IdShop != 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "a");
                __builder2.AddAttribute(16, "href", "/shop/" + (
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                     ShopUrl(user.IdShop)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "b-8igy2qtvpp");
                __builder2.AddMarkupContent(18, "Магазин");
                __builder2.CloseElement();
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                     if (user.LevelUser == UserLevel.Third && user.IdShop == 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(19, "<a href=\"/createshop\" b-8igy2qtvpp>Создать магазин</a>");
#nullable restore
#line 22 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                                              }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(20, "<a href=\"/purchases\" b-8igy2qtvpp>Покупки</a>\r\n                    ");
                __builder2.AddMarkupContent(21, "<a href=\"/sales\" b-8igy2qtvpp>Продажи</a>\r\n                    ");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "href", "/messager");
                __builder2.AddAttribute(24, "b-8igy2qtvpp");
                __builder2.AddContent(25, 
#nullable restore
#line 25 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                         message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.AddMarkupContent(27, "<a href=\"/logout\" b-8igy2qtvpp>Log out</a>\r\n                    ");
                __builder2.OpenElement(28, "a");
                __builder2.AddAttribute(29, "href", "/user/" + (
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                    context.User.FindFirst(ClaimTypes.NameIdentifier).Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "target", "_top");
                __builder2.AddAttribute(31, "b-8igy2qtvpp");
                __builder2.OpenElement(32, "img");
                __builder2.AddAttribute(33, "class", "user-img-top");
                __builder2.AddAttribute(34, "src", "/img/avatars/" + (
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
                                                                                                                                                        context.User.Claims.FirstOrDefault(i => i.Type == "PathAvatar").Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "b-8igy2qtvpp");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(36, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(37, "<div class=\"top-row px-4\" b-8igy2qtvpp><a href=\"/signup\" b-8igy2qtvpp>Sign up</a>\r\n                    <a href=\"/signin\" b-8igy2qtvpp>Sign in</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "content px-4");
            __builder.AddAttribute(41, "b-8igy2qtvpp");
            __builder.AddContent(42, 
#nullable restore
#line 39 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MainLayout.razor"
      
    [Inject] IHttpContextAccessor htp { get; set; }
    HubConnection hubConnection;
    string message;
    User user;
    protected override async Task OnInitializedAsync()
    {
        if (htp.HttpContext.User.Claims.Any())
        {
            user = SqlUser.GetUserById(int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value));
        }
        message = "Cooбщения";
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
