using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public class SQLOffer : IOffer
    {
        private readonly DBContext _context;
        public SQLOffer(DBContext context)
        {
            _context = context;
        }

        public void AddOffer(Offer offer)
        {
            _context.Offers.Add(offer);
            _context.SaveChanges();
        }

        public Offer GetOfferById(int offerId)
        {
            return _context.Offers.FirstOrDefault(item => item.Id == offerId);
        }

        public Offer GetOfferByIdentityName(string identityName)
        {
            return _context.Offers.FirstOrDefault(item => item.IdentifierName == identityName);
        }

        public IEnumerable<Offer> GetOffersByCustonerId(int customerId)
        {
            return _context.Offers.Where(item => item.CustomerId == customerId);
        }

        public IEnumerable<Offer> GetOffersByVendorId(int vendorId)
        {
            return _context.Offers.Where(item => item.VendorId == vendorId);
        }

        public void RemoveOffer(int offerId)
        {
            _context.Offers.Remove(_context.Offers.FirstOrDefault(item => item.Id == offerId));
        }

        public void UpdateOffer(Offer offer)
        {
            var of = _context.Attach(offer);
            of.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
