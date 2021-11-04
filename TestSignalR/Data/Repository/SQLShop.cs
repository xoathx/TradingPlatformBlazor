using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLShop : IShop
    {
        private readonly DBContext _context;
        public SQLShop(DBContext context)
        {
            _context = context;
        }
        public void AddShop(Shop shop)
        {
            _context.Add(shop);
            _context.SaveChanges();
        }

        public Shop GetShopByCreatedId(int createdId)
        {
            return _context.Shops.FirstOrDefault(item => item.CreatedId == createdId);
        }

        public Shop GetShopById(int shopId)
        {
            return _context.Shops.FirstOrDefault(item => item.Id == shopId);
        }

        public Shop GetShopByShortUrl(string shortUrl)
        {
            return _context.Shops.FirstOrDefault(item => item.ShortNameShop == shortUrl);
        }

        public bool IsNameTaken(string nameShop)
        {
            return _context.Shops.Any(item => item.NameShop == nameShop);
        }

        public void RemoveShop(int shopId)
        {
            _context.Shops.Remove(GetShopById(shopId));
            _context.SaveChanges();
        }

        public void UpdateShop(Shop updateShop)
        {
            var shop = _context.Attach(updateShop);
            shop.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
