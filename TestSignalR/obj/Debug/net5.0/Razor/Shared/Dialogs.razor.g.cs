#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388fe79a3528904ea890a842a35616b170d9af7d"
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
    public partial class Dialogs : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "col-12 col-lg-5 col-xl-3 border-right");
                __builder2.AddMarkupContent(4, "<div class=\"px-4 d-none d-md-block\"><div class=\"d-flex align-items-center\"></div></div>");
#nullable restore
#line 14 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
         foreach (var item in GroupDialogs)
        {
            var _user = Get(item.Key);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "a");
                __builder2.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
                         (() => Change(_user.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "class", "list-group-item list-group-item-action border-0");
                __builder2.AddMarkupContent(8, "<div class=\"badge bg-success float-right\"></div>\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "d-flex align-items-start");
                __builder2.OpenElement(11, "img");
                __builder2.AddAttribute(12, "src", "/img/avatars/" + (
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
                                            _user.PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "class", "rounded-circle mr-1");
                __builder2.AddAttribute(14, "alt", 
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
                                                                                                _user.NickName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "width", "40");
                __builder2.AddAttribute(16, "height", "40");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "flex-grow-1 ml-3");
                __builder2.AddContent(20, 
#nullable restore
#line 22 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
                         _user.NickName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "small");
                __builder2.AddMarkupContent(24, "<span class=\"fas fa-circle chat-online\"></span>");
                __builder2.AddContent(25, 
#nullable restore
#line 25 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
                                                                            MiniMessage(item.Last().BodyMessage)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"

        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(26, "<hr class=\"d-block d-lg-none mt-1 mb-0\">");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\Dialogs.razor"
       

    HubConnection hubConnection;
    private IEnumerable<Message> dialogs = new List<Message>();
    private int currentId;
    IEnumerable<IGrouping<int, Message>> GroupDialogs;


    protected override async Task OnInitializedAsync()
    {
        if (!(htp.HttpContext.User.Claims.Count() < 2))
        {
            currentId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            dialogs = SqlMessage.GetMessagesByToId(currentId).ToList().OrderBy(t => t.DateMessage).Reverse();
            GroupDialogs = dialogs.GroupBy(g => g.FromUserId).ToList();
            hubConnection = new HubConnectionBuilder()
          .WithUrl(nav.ToAbsoluteUri("/hub"), opt =>
          {
              if (htp.HttpContext.Request.Cookies.Count > 0)
              {
                  opt.Cookies.Add(new Uri(nav.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
              }
          }).Build();
            hubConnection.On<Message>("ReceiveMessage", (message) =>
            {
                UpdateWindow();

            });
            await hubConnection.StartAsync();
        }

    }

    User Get(int id)
    {
        return SqlUser.GetUserById(id);
    }
    string MiniMessage(string str)
    {
        if (str.Length > 10)
        {
            return new string(str.Substring(0, 10) + "...");
        }
        return str;
    }
    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    private async Task Change(int id)
    {

        await hubConnection.SendAsync("UpdateCompanionId", id);

    }

    private void UpdateWindow()
    {

        dialogs = SqlMessage.GetMessagesByToId(currentId).ToList().OrderBy(t => t.DateMessage).Reverse();
        GroupDialogs = dialogs.GroupBy(g => g.FromUserId).ToList();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IMessage SqlMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
