// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/lot/{id:int}")]
    public partial class PageLot : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
