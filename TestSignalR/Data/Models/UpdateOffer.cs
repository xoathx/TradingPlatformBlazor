using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class UpdateOffer
    {
        public int UserId { get; set; }
        public StateOffer StateOffer { get; set; }
    }
}
