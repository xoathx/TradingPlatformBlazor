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
        void AddLot(ShopLot addedLot);
        void DeleteLot(ShopLot deletedLot);
        void UpdateLot(ShopLot changedLot);
        IEnumerable<ShopLot> GetShopLotsByShopId(int shopId);
        ShopLot GetShopLotById(int shopLotId);
    }
}
