using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class ShopLot
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nameLot")]
        public string NameLot { get; set; }
        [Column("descLot")]
        public string DescLot { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("shop_Id")]
        public int ShopId { get; set; }
    }
}
