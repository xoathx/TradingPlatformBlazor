#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffeeb7bc5234338b71f062fb122b3b30d38fb634"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{Id:int}")]
    public partial class ProfileUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
 if (user == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h3");
            __builder.AddContent(3, 
#nullable restore
#line 15 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
         user.NickName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "class", "profile-avatar");
            __builder.AddAttribute(7, "src", "/img/avatars/" + (
#nullable restore
#line 16 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                   user.PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(9);
            __builder.AddAttribute(10, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                           user.NickName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "class", "btn btn-info");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                               OpenSettings

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(15, "Настройки");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "user-lots");
            __builder.AddMarkupContent(18, "<div class=\"gds-user\"><p class=\"text-muted\">Товары</p></div>\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container");
            __builder.AddMarkupContent(21, @"<div class=""row""><div class=""col-6 col-sm-3 name-category-user border-right"">
                    Категория
                </div>
                <div class=""col name-lot-user"">
                    Название лота
                </div>
                <div class=""col desc-lot-user border-left"">
                    Описание
                </div></div>");
#nullable restore
#line 37 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             foreach (var item in LotsOfVendor)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "a-lot-user");
            __builder.AddAttribute(24, "href", "/lot/" + (
#nullable restore
#line 39 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                  item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row border lot-body");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-6 col-sm-3 name-category-user border-right");
            __builder.AddContent(29, 
#nullable restore
#line 43 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                 CategoryName(item.CategoryId)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col name-lot-user ");
            __builder.AddContent(33, 
#nullable restore
#line 46 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                 item.NameLot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col desc-lot-user border-left");
            __builder.AddContent(37, 
#nullable restore
#line 49 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                 MiniString(item.DescLot)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "comments-user ");
            __builder.AddMarkupContent(41, "<div class=\"h-comments-user\"><p class=\"text-muted\">Отзывы</p></div>\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "container");
#nullable restore
#line 63 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             foreach (var item in CommentsAbUser)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "a-comment-user");
            __builder.AddAttribute(46, "href", "/offer/" + (
#nullable restore
#line 65 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                    item.OfferId

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row border comment-body");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "a-comment-user");
            __builder.AddAttribute(51, "href", "/user/" + (
#nullable restore
#line 68 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                           item.FromUserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "target", "_top");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col nickname-comment-user ");
            __builder.OpenElement(55, "img");
            __builder.AddAttribute(56, "class", "avatar d-inline avatar-comment-user");
            __builder.AddAttribute(57, "src", "/img/avatars/" + (
#nullable restore
#line 70 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                                                                SqlUser.GetUserById(item.FromUserId).PathAvatar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.AddContent(59, 
#nullable restore
#line 71 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                             SqlUser.GetUserById(item.FromUserId).NickName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-6 col-sm-3 bodytext-comment-user");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, 
#nullable restore
#line 75 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                            item.BodyComment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "rating-mini rating-comment-user");
#nullable restore
#line 79 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                             for (int i = 1; i <= 5; i++)
                            {
                                if (i <= item.ValueRating)
                                {
                                    selector = "active";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "class", 
#nullable restore
#line 84 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                  selector

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<span></span>");
#nullable restore
#line 89 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
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
#line 96 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             if (DialogOpen)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TradingPlatformBlazor.Shared.UserSettings>(73);
            __builder.AddAttribute(74, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 101 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                      user.NickName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 101 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
                                                              OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 102 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
             

        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\ProfileUser.razor"
       
    [Parameter]
    public int Id { get; set; }
    User user;
    IEnumerable<Lot> LotsOfVendor;
    IEnumerable<Comment> CommentsAbUser;
    string message;
    public int testRate = 3;
    string selector;
    public bool DialogOpen { get; set; }
    protected override void OnInitialized()
    {

        if (SqlUser.GetUserById(Id) == null)
        {

            message = "Страница не найдена.";
        }
        else
        {
            user = SqlUser.GetUserById(Id);
            LotsOfVendor = SqlLot.AllLotsOfVendor(Id).ToList();
            CommentsAbUser = SqlComment.GetCommentsByToUserId(Id).ToList();
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
        if (string.IsNullOrWhiteSpace(str)) { return str; } else {
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IComment SqlComment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ICategory SqlCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
    }
}
#pragma warning restore 1591
