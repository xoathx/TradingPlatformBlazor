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
#line 10 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/offer/{IdOffer:int}")]
    public partial class PageOffer : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\uothy\source\repos\TradingPlatformBlazor\TestSignalR\Pages\PageOffer.razor"
       
    [Parameter]
    public int IdOffer { get; set; }
    HubConnection hubConnection;
    private Offer currentOffer;
    string message;
    private string messageState = "В процессе...";
    private string selectorState = "inprocessOffer";
    private string currentUserName;
    private string globalRoles;
    private string selector;
    private int customerId;
    private User Vendor;
    private User Customer;
    private Comment Comment;
    private Shop VendorShop;
    IEnumerable<User> MembersShop = new List<User>();
    private bool OpenDialog { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentOffer = SqlOffer.GetOfferById(IdOffer);
        if (currentOffer == null)
        {
            message = "Страница не найдена.";
        }
        else
        {
            if(currentOffer.ShopLotId == 0 && currentOffer.VendorShopId == 0)
            {
                Customer = SqlUser.GetUserById(currentOffer.CustomerId);
                Vendor = SqlUser.GetUserById(currentOffer.VendorId);
                Comment = SqlComment.GetCommentByOfferId(currentOffer.Id);
                currentUserName = htp.HttpContext.User.Identity.Name;
                customerId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
                globalRoles = SqlUser.GetUserById(currentOffer.CustomerId).NickName + ", " + SqlUser.GetUserById(currentOffer.VendorId).NickName;
            }
            else
            {
                Customer = SqlUser.GetUserById(currentOffer.CustomerId);
                VendorShop = SqlShop.GetShopById(currentOffer.VendorShopId);
                Comment = SqlComment.GetCommentByOfferId(currentOffer.Id);
                currentUserName = htp.HttpContext.User.Identity.Name;
                customerId = int.Parse(htp.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
                MembersShop = SqlUser.GetShopMembersByShopId(VendorShop.Id);
                globalRoles = GetGlobalRoles(MembersShop) + Customer.NickName;
            }
        }
        hubConnection = new HubConnectionBuilder()
  .WithUrl(nav.ToAbsoluteUri("/hub"), opt =>
  {
      if (htp.HttpContext.Request.Cookies.Count > 0)
      {
          opt.Cookies.Add(new Uri(nav.BaseUri), new System.Net.Cookie("Cookie", htp.HttpContext.Request.Cookies.Where(s => s.Key == "Cookie").FirstOrDefault().Value));
      }
  }).Build();
        hubConnection.On<UpdateOffer>("UpdatingOffer", (update) =>
        {
            if (update.StateOffer == StateOffer.Canceled)
            {
                CanseledOffer();
                StateHasChanged();
            }
            if (update.StateOffer == StateOffer.Completed)
            {
                CompletedOffer();
                StateHasChanged();
            }
        });
        await hubConnection.StartAsync();
    }

    void CompletedOffer()
    {
        selectorState = "completedOffer";
        messageState = "Завершено";
        currentOffer.IsOpenned = false;
        currentOffer.DateClosing = DateTime.Now;
        currentOffer.StateOffer = StateOffer.Completed;

        SqlOffer.UpdateOffer(currentOffer);
        SqlLot.DeleteLot(SqlLot.GetLotByID(currentOffer.LotId));

        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }
    void CanseledOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        currentOffer.StateOffer = StateOffer.Canceled;
        currentOffer.IsOpenned = false;
        SqlUser.ManyBack(currentOffer.CustomerId, currentOffer.LotsPrice);
        currentOffer.IsManyBack = true;
        SqlOffer.UpdateOffer(currentOffer);
        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }

    void ManyBack()
    {
        selectorState = "manybackOffer";
        messageState = "Возврат";
        currentOffer.StateOffer = StateOffer.ManyBack;
        currentOffer.IsOpenned = false;
        SqlUser.ManyBack(currentOffer.CustomerId, currentOffer.LotsPrice);
        currentOffer.IsManyBack = true;

        SqlOffer.UpdateOffer(currentOffer);
        nav.NavigateTo(nav.Uri, true);
        StateHasChanged();
    }
    async Task CustomerCompletedOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        UpdateOffer updateOffer = new UpdateOffer()
        {
            UserId = currentOffer.VendorId,
            StateOffer = StateOffer.Completed
        };
        await hubConnection.SendAsync("UpdateOffer", updateOffer);
        StateHasChanged();
    }
    async Task CustomerCanseledOffer()
    {
        selectorState = "canseledOffer";
        messageState = "Отменен";
        UpdateOffer updateOffer = new UpdateOffer()
        {
            UserId = currentOffer.VendorId,
            StateOffer = StateOffer.Canceled
        };
        await hubConnection.SendAsync("UpdateOffer", updateOffer);
        StateHasChanged();
    }

    private void OnDialogClose()
    {
        OpenDialog = false;
    }
    private void OnDialogOpen()
    {
        OpenDialog = true;
    }
    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    private string GetGlobalRoles(IEnumerable<User> members)
    {
        string result = string.Empty;
        foreach(var item in members)
            {
                result += item.NickName + ",";
            }
        return result;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor htp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IShop SqlShop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IComment SqlComment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IUser SqlUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.ILot SqlLot { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TradingPlatformBlazor.Data.Repository.IOffer SqlOffer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
