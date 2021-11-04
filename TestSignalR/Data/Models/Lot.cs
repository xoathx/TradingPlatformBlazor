using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Lot
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nameLot")]
        public string NameLot { get; set; }
        [Column("descLot")]
        public string DescLot { get; set; }
        [Column("vendorNick")]
        public string VendorsNick { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("categoryId")]
        public int CategoryId { get; set; }
        [Column("vendorId")]
        public int VendorId { get; set; }
        [Column("shop_vendor")]
        public int ShopId { get; set; }
    }
}
