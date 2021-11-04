using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLLot : ILot
    {
        private readonly DBContext _context;

        public SQLLot(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Lot> AllLots()
        {
            return _context.Lots;
        }

        public void AddLot(Lot addedLot)
        {
            var lot = addedLot;
            _context.Lots.Add(lot);
            _context.SaveChanges();
        }

        public void UpdateLot(Lot changedLot)
        {
            var lot = _context.Lots.Attach(changedLot);
            lot.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }

        public void DeleteLot(Lot deletedLot)
        {
            if (deletedLot != null)
            {
                _context.Remove(deletedLot);
                _context.SaveChanges();
            }
        }

        public User LotsVendor(Lot lot)
        {
            return _context.Users.Find(lot.VendorId);
        }

        public IEnumerable<Lot> LotsByID(int categoryId)
        {
            return _context.Lots.Where(items => items.CategoryId == categoryId);
        }

        public IEnumerable<Lot> AllLotsOfVendor(int vendorId)
        {
            return _context.Lots.Where(i => i.VendorId == vendorId);
        }

        public Lot GetLotByID(int lotId)
        {
            return _context.Lots.FirstOrDefault(item => item.Id == lotId);
        }
    }
}
