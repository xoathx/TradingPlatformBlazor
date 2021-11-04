using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data.Repository
{
    public interface IOffer
    {
        IEnumerable<Offer> GetOffersByVendorId(int vendorId);
        IEnumerable<Offer> GetOffersByCustonerId(int customerId);
        Offer GetOfferById(int offerId);
        Offer GetOfferByIdentityName(string identityName);
        void AddOffer(Offer offer);
        void RemoveOffer(int offerId);
        void UpdateOffer(Offer offer);

    }
}
