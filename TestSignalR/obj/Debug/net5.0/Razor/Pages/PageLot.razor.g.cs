#pragma checksum "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f98d02451fa603a52de60505d992a4e4f903bfc1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/lot/{id:int}")]
    public partial class PageLot : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
 if (currentLot == null || htp.HttpContext.User.Claims.Count() < 2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 12 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.AddContent(8, 
#nullable restore
#line 19 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                 message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 20 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                     categoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h2");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                     currentLot.NameLot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                <hr align=\"left\" width=\"500px\" color=\"#80CEFD\">\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "descLot");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 24 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                        currentLot.DescLot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                <hr align=\"left\" width=\"500px\" color=\"#80CEFD\">\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "priceLot");
            __builder.AddMarkupContent(23, "Цена: ");
            __builder.AddContent(24, 
#nullable restore
#line 27 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                             currentLot.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(26);
            __builder.AddAttribute(27, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                       rolesButton

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn btn-success");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                                                  BuyLot

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "Купить");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(34);
            __builder.AddAttribute(35, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                       roles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "class", "btn btn-light");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                                            OpenDialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "Изменить лот");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 40 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                         if (int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(t => t.Type == ClaimTypes.NameIdentifier).Value) != vendorId)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<TradingPlatformBlazor.Shared.Chat>(46);
                __builder2.AddAttribute(47, "ToUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                            vendorId

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 43 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
     if (DialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TradingPlatformBlazor.Shared.UpdateLot>(48);
            __builder.AddAttribute(49, "UpdatingLot", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TradingPlatformBlazor.Data.Models.Lot>(
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                 currentLot

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 53 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
                                                      OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageLot.razor"
       

    [Parameter]
    public int id { get; set; }
    Lot currentLot;
    string categoryName;
    string roles;
    string message;
    string rolesButton;
    private int vendorId;
    public bool DialogOpen { get; set; }
    private double CurrentBalanceCustomer;
    private int currentUserId;
    private bool Succes;
    protected override void OnInitialized()
    {

        currentLot = SqlLot.GetLotByID(id);
        if (currentLot == null || htp.HttpContext.User.Claims.Count() < 2)
        {
            message = "Авторизуйтесь.";
        }
        else
        {
            rolesButton = htp.HttpContext.User.Identity.Name;
            if(rolesButton == currentLot.VendorsNick)
            {
                rolesButton = "0";
            }
            roles = currentLot.VendorsNick + ", " + UserRole.Administrator.ToString();
            categoryName = SqlCategory.GetNameCategory(currentLot.CategoryId);
            vendorId = currentLot.VendorId;
            Succes = int.TryParse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value, out currentUserId);
        }

    }

    private void OnDialogClose()
    {

        DialogOpen = false;


    }
    private void OpenDialog()
    {
        DialogOpen = true;
    }

    void BuyLot()
    {
        CurrentBalanceCustomer = SqlUser.GetUserBalanceById(currentUserId);
        if (CurrentBalanceCustomer < currentLot.Price)
        {
            message = "Недостаточно средств!";
        }
        else {
            SqlUser.ReduceBalance(currentUserId, currentLot.Price);
            string identityName = RandomIdentityName();
            Offer offer = new Offer()
            {
                IdentifierName = identityName,
                CategoryId = currentLot.CategoryId,
                LotId = currentLot.Id,
                LotsName = currentLot.NameLot,
                LotsDesc = currentLot.DescLot,
                LotsPrice = currentLot.Price,
                VendorId = currentLot.VendorId,
                CustomerId = currentUserId,
                IsOpenned = true,
                IsManyBack = false,
                DateOpenning = DateTime.Now,
                StateOffer = StateOffer.InProcess

            };
            SqlOffer.AddOffer(offer);
            string url = "/offer/" + SqlOffer.GetOfferByIdentityName(identityName).Id.ToString();
            Navigation.NavigateTo(url, true);
        }
    }

    string RandomIdentityName()
    {
        string result = string.Empty;
        string ABC = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            result += ABC[random.Next(0, ABC.Length)];
        }
        if(SqlOffer.GetOfferByIdentityName(result) != null)
        {
            return RandomIdentityName();
        }
        else
        {
            return result;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IOffer SqlOffer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ICategory SqlCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
    }
}
#pragma warning restore 1591
