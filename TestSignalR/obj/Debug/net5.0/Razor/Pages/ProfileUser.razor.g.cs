#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c28357386a2bef9785703572e56a9acb2e43ec2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{Id:int}")]
    public partial class ProfileUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
 if (user == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TradingPlatformBlazor.Shared.ErrorComponent>(0);
            __builder.AddAttribute(1, "ErrorCode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                               404

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "profile-nickname");
            __builder.AddAttribute(4, "b-jno4ptqhca");
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(5, user.NickName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "profile-avatar d-inline");
            __builder.AddAttribute(9, "src", "/img/avatars/" + (
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                            user.PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-jno4ptqhca");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Roles", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                           user.NickName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-avatar d-inline");
                __builder2.AddAttribute(17, "b-jno4ptqhca");
                __builder2.AddMarkupContent(18, "<div class=\"input-file-block\" b-jno4ptqhca><label for=\"file-upload\" class=\"custom-file-upload\" b-jno4ptqhca><i class=\"oi oi-data-transfer-upload\" b-jno4ptqhca></i>Upload\r\n                </label></div>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(19);
                __builder2.AddAttribute(20, "class", "file-select");
                __builder2.AddAttribute(21, "type", "file");
                __builder2.AddAttribute(22, "id", "file-upload");
                __builder2.AddAttribute(23, "accept", ".png,.jpg,.jpeg");
                __builder2.AddAttribute(24, "placeholder", "Обзор");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "user-lots");
            __builder.AddAttribute(27, "b-jno4ptqhca");
            __builder.AddMarkupContent(28, "<div class=\"gds-user\" b-jno4ptqhca><p class=\"text-muted\" b-jno4ptqhca>Товары</p></div>\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "container");
            __builder.AddAttribute(31, "b-jno4ptqhca");
            __builder.AddMarkupContent(32, @"<div class=""row"" b-jno4ptqhca><div class=""col-6 col-sm-3 name-category-user border-right"" b-jno4ptqhca>
                    Категория
                </div>
                <div class=""col name-lot-user"" b-jno4ptqhca>
                    Название лота
                </div>
                <div class=""col desc-lot-user border-left"" b-jno4ptqhca>
                    Описание
                </div></div>");
#nullable restore
#line 46 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             foreach (var item in LotsOfVendor)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "a-lot-user");
            __builder.AddAttribute(35, "href", "/lot/" + (
#nullable restore
#line 48 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                  item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "b-jno4ptqhca");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row border lot-body");
            __builder.AddAttribute(39, "b-jno4ptqhca");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-6 col-sm-3 name-category-user border-right");
            __builder.AddAttribute(42, "b-jno4ptqhca");
#nullable restore
#line 52 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(43, CategoryName(item.CategoryId));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col name-lot-user ");
            __builder.AddAttribute(47, "b-jno4ptqhca");
#nullable restore
#line 55 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(48, item.NameLot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col desc-lot-user border-left");
            __builder.AddAttribute(52, "b-jno4ptqhca");
#nullable restore
#line 58 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(53, MiniString(item.DescLot));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "comments-user ");
            __builder.AddAttribute(57, "b-jno4ptqhca");
            __builder.AddMarkupContent(58, "<div class=\"h-comments-user\" b-jno4ptqhca><p class=\"text-muted\" b-jno4ptqhca>Отзывы</p></div>\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "container");
            __builder.AddAttribute(61, "b-jno4ptqhca");
#nullable restore
#line 72 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             foreach (var item in CommentsAbUser)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "a-comment-user");
            __builder.AddAttribute(64, "href", "/offer/" + (
#nullable restore
#line 74 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                        item.OfferId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "b-jno4ptqhca");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row border comment-body");
            __builder.AddAttribute(68, "b-jno4ptqhca");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "class", "a-comment-user");
            __builder.AddAttribute(71, "href", "/user/" + (
#nullable restore
#line 77 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                               item.FromUserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "target", "_top");
            __builder.AddAttribute(73, "b-jno4ptqhca");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col nickname-comment-user ");
            __builder.AddAttribute(76, "b-jno4ptqhca");
            __builder.OpenElement(77, "img");
            __builder.AddAttribute(78, "class", "avatar d-inline avatar-comment-user");
            __builder.AddAttribute(79, "src", "/img/avatars/" + (
#nullable restore
#line 79 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                                                                    SqlUser.GetUserById(item.FromUserId).PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "b-jno4ptqhca");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                ");
#nullable restore
#line 80 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(82, SqlUser.GetUserById(item.FromUserId).NickName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-6 col-sm-3 bodytext-comment-user");
            __builder.AddAttribute(86, "b-jno4ptqhca");
            __builder.OpenElement(87, "p");
            __builder.AddAttribute(88, "b-jno4ptqhca");
#nullable restore
#line 84 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
__builder.AddContent(89, item.BodyComment);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col");
            __builder.AddAttribute(93, "b-jno4ptqhca");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "rating-mini rating-comment-user");
            __builder.AddAttribute(96, "b-jno4ptqhca");
#nullable restore
#line 88 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                 for (int i = 1; i <= 5; i++)
                                {
                                    if (i <= item.ValueRating)
                                    {
                                        selector = "active";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", 
#nullable restore
#line 93 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                      selector

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(99, "b-jno4ptqhca");
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "<span b-jno4ptqhca></span>");
#nullable restore
#line 98 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                    }
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 108 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
     if (DialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TradingPlatformBlazor.Shared.UserSettings>(101);
            __builder.AddAttribute(102, "CurrentUser", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TradingPlatformBlazor.Data.Models.User>(
#nullable restore
#line 110 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                   user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 110 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                  OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 111 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
       
    [Parameter]
    public int Id { get; set; }
    User user;
    IEnumerable<Lot> LotsOfVendor;
    IEnumerable<Comment> CommentsAbUser;

    public int testRate = 3;
    string selector;
    public bool DialogOpen { get; set; }
    protected override async Task OnInitializedAsync()
    {


        if(SqlUser.GetUserById(Id) != null)
        {
            user = SqlUser.GetUserById(Id);
            LotsOfVendor = SqlLot.AllLotsOfVendor(Id).ToList();
            CommentsAbUser = SqlComment.GetCommentsByToUserId(Id).ToList();
            await JSRuntime.InvokeVoidAsync("setTitle", "Пользователь " + user.NickName);
        }

    }



    string CategoryName(int categoryID)
    {
        return SqlCategory.GetNameCategory(categoryID);
    }

    private void OpenSettings()
    {
        DialogOpen = true;
    }

    private void OnDialogClose()
    {

        DialogOpen = false;

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IComment SqlComment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ICategory SqlCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
    }
}
#pragma warning restore 1591
