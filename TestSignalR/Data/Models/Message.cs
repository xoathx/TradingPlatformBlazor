using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Message
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("body_message")]
        public string BodyMessage { get; set; }
        [Column("date_message")]
        public DateTime DateMessage { get; set; }
        [Column("from_user_id")]
        public int FromUserId { get; set; }
        [Column("to_user_id")]
        public int ToUserId { get; set; }
    }
}
