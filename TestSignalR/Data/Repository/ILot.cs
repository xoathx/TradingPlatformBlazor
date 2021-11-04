using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface ILot
    {
        IEnumerable<Lot> AllLots();
        IEnumerable<Lot> LotsByID(int categoryId);
        void AddLot(Lot addedLot);
        void DeleteLot(Lot deletedLot);
        void UpdateLot(Lot changedLot);
        User LotsVendor(Lot lot);
        IEnumerable<Lot> AllLotsOfVendor(int vendorId);
        Lot GetLotByID(int lotId);
    }
}
