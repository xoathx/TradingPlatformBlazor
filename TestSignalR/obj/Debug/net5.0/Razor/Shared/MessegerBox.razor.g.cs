#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d8ce366ea9640d56f7749d607f3d0b595548860"
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
    public partial class MessegerBox : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "Авторизуйтесь!");
            }
            ));
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
         if (currentUser == null)
        {



#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "<h1 class=\"message-info\">Тут будут ваши сообщения</h1>");
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "py-2 px-4 border-custom d-none d-lg-block");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "d-flex align-items-center py-1");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "position-relative");
                __builder2.OpenElement(11, "a");
                __builder2.AddAttribute(12, "href", "/user/" + (
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                        currentUser.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(13, "img");
                __builder2.AddAttribute(14, "src", "/img//avatars/" + (
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                                                 currentUser.PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "class", "rounded-circle mr-1");
                __builder2.AddAttribute(16, "alt", 
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                                                                                                           currentUser.NickName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(17, "width", "40");
                __builder2.AddAttribute(18, "height", "40");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "flex-grow-1 pl-3 d-inline");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "class", "link-chat-companion");
                __builder2.AddAttribute(24, "href", "/user/" + (
#nullable restore
#line 26 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                                    currentUser.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(25, "strong");
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
__builder2.AddContent(26, currentUser.NickName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "text-muted small");
#nullable restore
#line 28 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                           if (UserStatus.GetStatus(currentUser.Id))
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(30, "<em class=\"text-success\">Online</em>");
#nullable restore
#line 29 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                                 }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<em>Offline</em>");
#nullable restore
#line 31 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                             }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.AddMarkupContent(33, @"<div><button class=""btn btn-light border btn-lg px-3""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-more-horizontal feather-lg""><circle cx=""12"" cy=""12"" r=""1""></circle><circle cx=""19"" cy=""12"" r=""1""></circle><circle cx=""5"" cy=""12"" r=""1""></circle></svg></button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "position-relative");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "id", "messeger-content");
                __builder2.AddAttribute(38, "class", "chat-messages p-4");
#nullable restore
#line 43 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                     foreach (var item in messages)
                    {
                        if (item.FromUserId == myId)
                        {
                            selectorClass = "chat-message-right pb-4";
                        }
                        else
                        {
                            selectorClass = "chat-message-left pb-4";
                        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", 
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                     selectorClass

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(41, "div");
                __builder2.OpenElement(42, "img");
                __builder2.AddAttribute(43, "src", "/img/avatars/" + (
#nullable restore
#line 55 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                        SqlUser.GetUserById(item.FromUserId).PathAvatar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "class", "rounded-circle mr-1");
                __builder2.AddAttribute(45, "alt", "Chris Wood");
                __builder2.AddAttribute(46, "width", "40");
                __builder2.AddAttribute(47, "height", "40");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "text-muted small text-nowrap mt-2");
#nullable restore
#line 56 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
__builder2.AddContent(51, item.DateMessage.ToString("t"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "flex-shrink-1 bg-light rounded py-2 px-3 mr-3");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "font-weight-bold mb-1");
#nullable restore
#line 59 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
__builder2.AddContent(57, SqlUser.GetUserById(item.FromUserId).NickName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                                ");
#nullable restore
#line 60 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
__builder2.AddContent(59, item.BodyMessage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "flex-grow-0 py-3 px-4 border-top");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "input-group");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "placeholder", "Type your message");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                  messageInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "class", "btn btn-primary");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
                                                                  Send

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(75, "Send");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
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
#line 79 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\MessegerBox.razor"
       
        //[Parameter]
    public int IdСompanion { get; set; }
    private List<Message> messages = new List<Message>();
    private HubConnection hubConnection;
    private string messageInput;
    User currentUser;
    private int myId;
    private string selectorClass;


    protected override async Task OnInitializedAsync()
    {

        myId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
        hubConnection = new HubConnectionBuilder()
.WithUrl(nav.ToAbsoluteUri("/hub"), opt =>
{
    if (htp.HttpContext.Request.Cookies.Count > 0)
    {
        opt.Cookies.Add(new Uri(nav.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
    }
}).Build();

        hubConnection.On<int>("Update", (id) =>
        {
            ClearWin();
            UpdateComponion(id);
            StateHasChanged();
        });

        hubConnection.On<Message>("ReceiveMessage", (message) =>
        {
            if (message.FromUserId == IdСompanion || (message.ToUserId == IdСompanion && message.FromUserId == myId))
            {

                messages.Add(message);
                StateHasChanged();
            }

        });

        await hubConnection.StartAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (currentUser != null) 
        {
            await JSRuntime.InvokeVoidAsync("scrollDown", "messeger-content"); 
        }
    }

    async Task Send()
    {
        Message message = new Message()
        {
            BodyMessage = messageInput,
            DateMessage = DateTime.Now,
            FromUserId = myId,
            ToUserId = IdСompanion
        };
        await hubConnection.SendAsync("SendSpecific", message);
        messageInput = string.Empty;
        SqlMessage.AddMessage(message);
        StateHasChanged();
    }

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    public void UpdateComponion(int id)
    {
        IdСompanion = id;
        currentUser = SqlUser.GetUserById(IdСompanion);

        var fromMessages = SqlMessage.GetMessagesByIdFromAndIdTo(myId, IdСompanion).ToList();
        var toMessages = SqlMessage.GetMessagesByIdFromAndIdTo(IdСompanion, myId).ToList();
        messages.AddRange(fromMessages);
        messages.AddRange(toMessages);
        messages = messages.OrderBy(c => c.DateMessage).ToList();
    }
    public void ClearWin()
    {
        messages.Clear();
        currentUser = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Services.IUserStatus UserStatus { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IMessage SqlMessage { get; set; }
    }
}
#pragma warning restore 1591
