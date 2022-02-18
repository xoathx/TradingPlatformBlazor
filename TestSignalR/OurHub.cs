using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;
using TradingPlatformBlazor.Data.Repository;
using Microsoft.Extensions.Logging;
using TradingPlatformBlazor.Data.Services;

namespace TradingPlatformBlazor
{
    public class OurHub : Hub
    {
        private readonly IShop _context;
        private readonly IUser _userContext;
        private readonly IUserStatus _userStatus;
        private readonly ILogger<OurHub> _logger;
        private User CurrentUser;
        public OurHub(IShop context, IUser userContext, IUserStatus userStatus, ILogger<OurHub> logger)
        {
            _context = context;
            _userContext = userContext;
            _logger = logger;
            _userStatus = userStatus;
        }
        
        public override Task OnConnectedAsync()
        {
            
            if(Context.User.Claims.Any())
            {
                CurrentUser = _userContext.GetUserById(int.Parse(Context.UserIdentifier));
                _userStatus.SetOnline(CurrentUser);
                _logger.LogWarning("{0} connect", Context.User.Claims.Where(s => s.Type == ClaimTypes.Name).FirstOrDefault().Value);
            }
           


            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Claims.Any())
            {
                CurrentUser = _userContext.GetUserById(int.Parse(Context.UserIdentifier));
                _userStatus.SetOffline(CurrentUser);
                _logger.LogWarning("{0} disconnect", Context.User.Claims.Where(s => s.Type == ClaimTypes.Name).FirstOrDefault().Value);
                return base.OnDisconnectedAsync(exception);
            }
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendSpecific(Message message)
        {
            var id = Context.User.Claims.Where(s => s.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
            await Clients.Users(message.ToUserId.ToString(), message.FromUserId.ToString()).SendAsync("ReceiveMessage", message);
           
        }
        
        public async Task UpdateCompanionId(int id)
        {
            var ident = Context.User.Claims.Where(s => s.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
            await Clients.User(ident).SendAsync("Update", id);
        }
        public async Task UpdateCompanionShopId(int shopId)
        {
            var ident = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            await Clients.User(ident).SendAsync("UpdateShop", shopId);
        }
        public async Task UpdateCompanionForShop(int userId)
        {
            var ident = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            await Clients.User(ident).SendAsync("UpdateCompanionIdForShop", userId);
        }
        public async Task UpdateOffer(UpdateOffer updateOffer)
        {
            var ident = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            await Clients.Users(ident, updateOffer.UserId.ToString()).SendAsync("UpdatingOffer", updateOffer);
        }

        public Task CreateGroup(int createdId, string nameShop)
        {
            return Groups.AddToGroupAsync(createdId.ToString(), nameShop);
        }

        public Task AddToShopChat(int addedId, string nameShop)
        {
            return Groups.AddToGroupAsync(addedId.ToString(), nameShop);
        }
        public async Task SendShopMessage(MessageShop messageShop)
        {
            var group = _context.GetShopById(messageShop.ShopId).ShortNameShop;
            await Clients.Users(messageShop.UserId.ToString(), Context.UserIdentifier).SendAsync("ReceiveMessageShop", messageShop);
        }
    }
}