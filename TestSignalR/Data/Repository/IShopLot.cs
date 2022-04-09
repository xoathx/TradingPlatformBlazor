using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IShopLot
    {
        IEnumerable<ShopLot> AllLots();
        IEnumerable<ShopLot> ShopLotsByCategoryId(int categoryId);
        IEnumerable<ShopLot> GetShopLotsByShopId(int shopId);
        ShopLot GetShopLotById(int shopLotId);
        void AddLot(ShopLot addedLot);
        void DeleteLot(ShopLot deletedLot);
        void UpdateLot(ShopLot changedLot);
        void RemoveAllShopLotsByCategoryId(int categoryId);
        
    }
}
