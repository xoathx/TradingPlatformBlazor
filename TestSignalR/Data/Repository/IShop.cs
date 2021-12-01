using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IShop
    {
        Shop GetShopById(int shopId);
        void AddShop(Shop shop);
        void RemoveShop(int shopId);
        void UpdateShop(Shop updateShop);
        Shop GetShopByCreatedId(int createdId);
        Shop GetShopByShortUrl(string shortUrl);
        bool IsNameTaken(string nameShop);
        bool IsAvatarReserved(string Name);
    }
}
