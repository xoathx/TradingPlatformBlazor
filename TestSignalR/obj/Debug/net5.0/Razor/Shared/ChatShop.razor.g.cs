#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5278d6ef3b15cb20b1868a377ec08aa20e59a1db"
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
#line 1 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class ChatShop : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-content page-container");
            __builder.AddAttribute(2, "id", "page-content");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row container d-flex justify-content-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card card-bordered");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-header chat-header-custom");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "link-chat-companion d-inline");
            __builder.AddAttribute(13, "href", "/shop/" + (
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                         currentShop.ShortNameShop

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "avatar d-inline");
            __builder.AddAttribute(16, "src", "/img/avatars/" + (
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                                                                                                    currentShop.PathAvatarShop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "alt", 
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                                                                                                                                      currentShop.NameShop

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(18, "  ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-title d-inline");
            __builder.OpenElement(21, "strong");
            __builder.AddAttribute(22, "class", "d-inline");
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
__builder.AddContent(23, currentShop.NameShop);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "ps-container ps-theme-default ps-active-y");
            __builder.AddAttribute(27, "id", "chat-content");
            __builder.AddAttribute(28, "style", "overflow-y: scroll !important; height:400px !important;");
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                     foreach (var item in messages)
                    {
                        
                        if (!item.IsShopMessage)
                        {
                            selectorClass = "media media-chat media-chat-reverse";
                        }
                        else { selectorClass = "media media-chat"; }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", 
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                     selectorClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "media-body");
            __builder.OpenElement(33, "p");
#nullable restore
#line 29 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
__builder.AddContent(34, item.BodyMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "p");
            __builder.AddAttribute(37, "class", "meta");
            __builder.OpenElement(38, "time");
            __builder.AddAttribute(39, "datetime", 
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                 item.DateMessage.Year

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
__builder.AddContent(40, item.DateMessage.ToString("t"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<div class=\"ps-scrollbar-x-rail\" style=\"left: 0px; bottom: 0px;\"><div class=\"ps-scrollbar-x\" tabindex=\"0\" style=\"left: 0px; width: 0px;\"></div></div>\r\n                    ");
            __builder.AddMarkupContent(42, "<div class=\"ps-scrollbar-y-rail\" style=\"top: 0px; height: 0px; right: 2px;\"><div class=\"ps-scrollbar-y\" tabindex=\"0\" style=\"top: 0px; height: 2px;\"></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "publisher bt-1 border-light");
            __builder.OpenElement(46, "img");
            __builder.AddAttribute(47, "class", "avatar avatar-xs");
            __builder.AddAttribute(48, "src", "/img/avatars/" + (
#nullable restore
#line 44 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                     htp.HttpContext.User.Claims.First(i => i.Type == "PathAvatar").Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "class", "publisher-input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "placeholder", "Write something");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                          messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(57, " ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
                                                                                                                                     Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "btn publisher-btn");
            __builder.AddContent(61, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ChatShop.razor"
       
    [Parameter]
    public int ToShopId { get; set; }
    private string FromId;
    private HubConnection hubConnection;
    private List<MessageShop> messages = new List<MessageShop>();
    private string messageInput;
    private Shop currentShop;
    private User CurrentUser;
    private int ShopMemberId;
    private string selectorClass;
    protected override async Task OnInitializedAsync()
    {
        CurrentUser = SqlUser.GetUserById(int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(i => i.Type == ClaimTypes.NameIdentifier).Value));
        currentShop = SqlShop.GetShopById(ToShopId);
        FromId = CurrentUser.Id.ToString();
        messages = SqlMessageShop.GetMessagesByUserIdAndShopId(CurrentUser.Id, ToShopId).ToList();
        hubConnection = new HubConnectionBuilder()
   .WithUrl(nav.ToAbsoluteUri("/hub"), opt =>
   {
       if (htp.HttpContext.Request.Cookies.Count > 0)
       {
           opt.Cookies.Add(new Uri(nav.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
       }
   }).Build();

        hubConnection.On<MessageShop>("ReceiveMessageShop", (message) =>
        {

            messages.Add(message);
            StateHasChanged();

        });

        await hubConnection.StartAsync();


    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("scrollDown", "chat-content");
    }

    async Task Send()
    {
        if(CurrentUser.IdShop != 0 && CurrentUser.IdShop == ToShopId)
        {
            ShopMemberId = CurrentUser.Id;
        }
        else
        {
            ShopMemberId = 0;
        }
        MessageShop messageShop = new MessageShop()
        {
            BodyMessage = messageInput,
            DateMessage = DateTime.Now,
            IsShopMessage = false,
            UserId = CurrentUser.Id,
            ShopId = ToShopId,
            ShopMemberId = ShopMemberId
        };
        await hubConnection.SendAsync("SendShopMessage", messageShop);
        messageInput = string.Empty;
        SqlMessageShop.AddMessage(messageShop);
        StateHasChanged();
    }

    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IMessageShop SqlMessageShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShop SqlShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
