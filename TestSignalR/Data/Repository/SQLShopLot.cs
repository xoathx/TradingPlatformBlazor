using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLShopLot : IShopLot
    {
        private readonly DBContext _context;
        public SQLShopLot(DBContext context)
        {
            _context = context;
        }
        public void AddLot(ShopLot addedShopLot)
        {
            _context.Add(addedShopLot);
            _context.SaveChanges();
        }

        public IEnumerable<ShopLot> AllLots()
        {
            return _context.ShopLots;
        }

        public IEnumerable<ShopLot> GetShopLotsByShopId(int shopId)
        {
            return _context.ShopLots.Where(item => item.ShopId == shopId);
        }

        public void DeleteLot(ShopLot deletedLot)
        {
            _context.Remove(deletedLot);
            _context.SaveChanges();
        }

        public ShopLot GetShopLotById(int shopLotId)
        {
            return _context.ShopLots.FirstOrDefault(item => item.Id == shopLotId);
        }

        public IEnumerable<ShopLot> ShopLotsByCategoryId(int categoryId)
        {
            return _context.ShopLots.Where(item => item.CategoryId == categoryId);
        }

        public void UpdateLot(ShopLot changedLot)
        {
            var item = _context.Attach(changedLot);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            
        }

        public void RemoveAllShopLotsByCategoryId(int categoryId)
        {
            var categoryLots = _context.ShopLots.Where(lots => lots.CategoryId == categoryId).ToList();
            if (categoryLots.Any())
            {
                foreach (var lot in categoryLots)
                {
                    DeleteLot(lot);
                }
            }
        }
    }
}
