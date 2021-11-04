using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Shop
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_created")]
        public int CreatedId { get; set; }
        [Column("short_name_shop")]
        public string ShortNameShop { get; set; }
        [Column("name_shop")]
        public string NameShop { get; set; }
        [Column("desc_shop")]
        public string DescShop { get; set; }
        [Column("shop_avatar")]
        public string PathAvatarShop { get; set; }

    }
}
