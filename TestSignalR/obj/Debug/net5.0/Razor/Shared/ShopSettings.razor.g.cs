#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd5517d1d12f026640624f2f1ae53c29e46f9410"
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
    public partial class ShopSettings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8);");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "b-j4gtno1bjv");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "b-j4gtno1bjv");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddAttribute(12, "b-j4gtno1bjv");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddAttribute(15, "b-j4gtno1bjv");
            __builder.OpenElement(16, "h4");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddAttribute(18, "b-j4gtno1bjv");
            __builder.AddContent(19, 
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                         CurrentShop.NameShop

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "b-j4gtno1bjv");
            __builder.AddContent(26, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddAttribute(30, "b-j4gtno1bjv");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "text-danger");
            __builder.AddAttribute(33, "b-j4gtno1bjv");
            __builder.AddContent(34, 
#nullable restore
#line 14 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                          message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(36);
            __builder.AddAttribute(37, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                      LoadingFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "accept", ".png, .jpg, .jpeg");
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "members-shop");
            __builder.AddAttribute(42, "b-j4gtno1bjv");
#nullable restore
#line 18 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                     foreach (var member in MembersShop)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "member");
            __builder.AddAttribute(45, "b-j4gtno1bjv");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "avatar avatar-member");
            __builder.AddAttribute(48, "b-j4gtno1bjv");
            __builder.OpenElement(49, "img");
            __builder.AddAttribute(50, "class", "avatar");
            __builder.AddAttribute(51, "src", "img/avatars/" + (
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                                                    member.PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "b-j4gtno1bjv");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "class", "d-inline nickname-member");
            __builder.AddAttribute(56, "b-j4gtno1bjv");
            __builder.AddContent(57, 
#nullable restore
#line 22 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                 member.NickName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                             if (member.Id == CurrentShop.CreatedId)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "<span class=\"fst-italic fw-lighter\" b-j4gtno1bjv>Владелец</span>");
#nullable restore
#line 26 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                  (() => DeleteMember(member))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "b-j4gtno1bjv");
            __builder.AddContent(62, "Delete");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                     if (MembersShop.Count() < 3)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "placeholder", "Введите ник");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                  NickNewMember

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NickNewMember = __value, NickNewMember));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(68, "b-j4gtno1bjv");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                  AddMember

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "b-j4gtno1bjv");
            __builder.AddMarkupContent(74, "Добавить участника");
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-footer");
            __builder.AddAttribute(78, "b-j4gtno1bjv");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "type", "button");
            __builder.AddAttribute(81, "class", "btn");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                             ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "b-j4gtno1bjv");
            __builder.AddContent(84, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "type", "button");
            __builder.AddAttribute(88, "class", "btn btn-primary");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                        ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "b-j4gtno1bjv");
            __builder.AddContent(91, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
       
    [Parameter]
    public Shop CurrentShop { get; set; }
    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private List<IBrowserFile> loadedFiles = new();
    private long maxFileSize = 1024 * 1024 * 200;
    //private int maxAllowedFiles = 1;
    private bool isLoading;
    private IReadOnlyList<IBrowserFile> browserFile;
    FileInfo file;
    IEnumerable<User> MembersShop = new List<User>();
    private User CurrentUser;
    private string filename;

    private string message;

    private string NickNewMember;
    protected override void OnInitialized()
    {
        isLoading = false;
        MembersShop = SqlUser.GetShopMembersByShopId(CurrentShop.Id).ToList();
        CurrentUser = SqlUser.GetUserById(int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value));
    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }
    private async Task ModalOk()
    {
        if (isLoading)
        {
            var path = Path.Combine(webHost.ContentRootPath, webHost.WebRootPath, "img", "avatars", filename + file.Extension);
            await using FileStream fs = new FileStream(path, FileMode.Create);
            await browserFile[0].OpenReadStream(maxFileSize).CopyToAsync(fs);

            var delPath = Path.Combine(webHost.ContentRootPath, webHost.WebRootPath, "img", "avatars", CurrentShop.PathAvatarShop);
            File.Delete(delPath);
            CurrentShop.PathAvatarShop = filename + file.Extension;
            SqlShop.UpdateShop(CurrentShop);
            isLoading = false;
        }
        await OnClose.InvokeAsync(true);
    }


    private void LoadingFile(InputFileChangeEventArgs e)
    {
        isLoading = true;
        loadedFiles.Clear();

        filename = GetRandomName();

        browserFile = e.GetMultipleFiles(1);
        file = new FileInfo(browserFile[0].Name);
    }

    string GetRandomName()
    {
        string abc = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        string result = string.Empty;
        Random random = new Random();
        for(int i = 0; i < 10; i++)
        {
            result += abc[random.Next(0, abc.Length - 1)];
        }
        if (!SqlShop.IsAvatarReserved(result) && !SqlUser.IsAvatarReserved(result)) { return result; } else { return GetRandomName(); }
    }

    void AddMember()
    {
        var newUser = SqlUser.GetUserByNickname(NickNewMember);
        if(newUser == null)
        {
            message = "Такого пользователя не существует!";
        }
        else
        {
            newUser.IdShop = CurrentShop.Id;
            SqlUser.UpdateUser(newUser);
            StateHasChanged();
        }
    }

    void DeleteMember(User deletedUser)
    {
        deletedUser.IdShop = 0;
        SqlUser.UpdateUser(deletedUser);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment webHost { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShop SqlShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
    }
}
#pragma warning restore 1591
