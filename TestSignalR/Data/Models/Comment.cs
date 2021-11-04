using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Comment
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("from_user_id")]
        public int FromUserId { get; set; }
        [Column("to_user_id")]
        public int ToUserId { get; set; }
        [Column("offer_id")]
        public int OfferId { get; set; }
        [Column("body_comment")]
        public string BodyComment { get; set; }
        [Column("date_comment")]
        public DateTime DateComment { get; set; }
        [Column("value_rating")]
        public byte ValueRating { get; set; }
    }
}
