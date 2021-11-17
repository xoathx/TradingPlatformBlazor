using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class MessageShop
    {
        [Column("id")]
        public int Id { get; set; }
        public string BodyMessage { get; set; }
        [Column("date_message")]
        public DateTime DateMessage { get; set; }
        [Column("is_shop_message")]
        public bool IsShopMessage { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("shop_id")]
        public int ShopId { get; set; }
        [Column("shop_member_id")]
        public int ShopMemberId { get; set; }
    }
}
