#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2307eae07452ed3e9b7ece33ea89cada99d0af0a"
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
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "modal-title");
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
__builder.AddContent(14, CurrentShop.NameShop);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-body");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "text-danger");
#nullable restore
#line 14 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
__builder.AddContent(26, message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "d-inline");
            __builder.AddMarkupContent(30, "<label for=\"file-upload\" class=\"custom-file-upload\"><i class=\"oi oi-data-transfer-upload\"></i>Upload\r\n                    </label>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(31);
            __builder.AddAttribute(32, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                          LoadingFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "id", "file-upload");
            __builder.AddAttribute(34, "accept", ".png, .jpg, .jpeg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<div class=\"d-inline\">???????????????? ????????????????????</div>\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "members-shop");
#nullable restore
#line 24 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                     foreach (var member in MembersShop)
                    {
                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "member");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "url-member");
            __builder.AddAttribute(43, "href", "/user/" + (
#nullable restore
#line 28 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                           member.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "avatar avatar-member");
            __builder.OpenElement(46, "img");
            __builder.AddAttribute(47, "class", "avatar");
            __builder.AddAttribute(48, "src", "img/avatars/" + (
#nullable restore
#line 29 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                                                    member.PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "d-inline nickname-member");
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
__builder.AddContent(52, member.NickName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                             if (member.Id == CurrentShop.CreatedId)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<span class=\"fst-italic fw-lighter role-member\">????????????????</span>");
#nullable restore
#line 35 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-danger delete-member");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                                       (() => DeleteMember(member))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Delete");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                    
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                     if (MembersShop.Count() < 3)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "text");
            __builder.AddAttribute(60, "class", "d-inline");
            __builder.AddAttribute(61, "placeholder", "?????????????? ??????");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                   NickNewMember

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NickNewMember = __value, NickNewMember));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "btn btn-primary d-inline");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                           AddMember

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "????????????????");
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-footer");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "btn");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                             ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "btn btn-primary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
                                                                        ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Shared\ShopSettings.razor"
       
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
        MembersShop = SqlUser.GetShopMembersByShopId(CurrentShop.Id).Reverse().ToList();
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
            message = "???????????? ???????????????????????? ???? ????????????????????!";
        }
        else
        {
            newUser.IdShop = CurrentShop.Id;
            SqlUser.UpdateUser(newUser);
            MembersShop = SqlUser.GetShopMembersByShopId(CurrentShop.Id).Reverse().ToList();
            StateHasChanged();
        }
    }

    void DeleteMember(User deletedUser)
    {
        deletedUser.IdShop = 0;
        SqlUser.UpdateUser(deletedUser);
        MembersShop = SqlUser.GetShopMembersByShopId(CurrentShop.Id).Reverse().ToList();
        StateHasChanged();
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
