using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLMessageShop : IMessageShop
    {
        private readonly DBContext _context;
        public SQLMessageShop(DBContext context)
        {
            _context = context;
        }
        public void AddMessage(MessageShop messageShop)
        {
            _context.MessageShops.Add(messageShop);
            _context.SaveChanges();
        }

        public IEnumerable<MessageShop> GetMessagesByShopId(int shopId)
        {
            return _context.MessageShops.Where(item => item.ShopId == shopId);
        }

        public IEnumerable<MessageShop> GetMessagesByUserId(int userId)
        {
            return _context.MessageShops.Where(item => item.UserId == userId);
        }

        public IEnumerable<MessageShop> GetMessagesByUserIdAndShopId(int userId, int shopId)
        {
            return _context.MessageShops.Where(item => item.ShopId == shopId && item.UserId == userId);
        }
    }
}
