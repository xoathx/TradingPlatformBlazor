using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;
using TradingPlatformBlazor.Data.Repository;

namespace TradingPlatformBlazor
{
    public class OurHub : Hub
    {
        private readonly IShop _context;
        public OurHub(IShop context)
        {
            _context = context;
        }
        
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
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
            await Clients.Group(group).SendAsync("ReceiveMessageShop", messageShop);
            await Clients.User(messageShop.UserId.ToString()).SendAsync("ReceiveMessageShop", messageShop);
        }
    }
}