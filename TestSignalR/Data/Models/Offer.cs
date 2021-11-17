using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Offer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("identifier_name")]
        public string IdentifierName { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("shop_lot_id")]
        public int ShopLotId { get; set; }
        [Column("lot_id")]
        public int LotId { get; set; }
        [Column("lots_name")]
        public string LotsName { get; set; }
        [Column("lots_desc")]
        public string LotsDesc { get; set; }
        [Column("lots_price")]
        public double LotsPrice { get; set; }
        [Column("vendor_id")]
        public int VendorId { get; set; }
        [Column("shop_vendor_id")]
        public int VendorShopId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("is_openned")]
        public bool IsOpenned { get; set; }
        [Column("is_manyback")]
        public bool IsManyBack { get; set; }
        [Column("is_commented")]
        public bool IsCommented { get; set; }
        [Column("date_openning")]
        public DateTime DateOpenning { get; set; }
        [Column("date_closing")]
        public DateTime DateClosing { get; set; }
        [Column("state_offer")]
        public StateOffer StateOffer { get; set; }
    }
    public enum StateOffer
    {
        InProcess,
        Completed,
        Canceled,
        ManyBack
    }
}
