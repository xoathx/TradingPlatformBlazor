using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class AccessToken
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("token")]
        public string Token { get; set; }
        [Column("nick")]
        public string Nick { get; set; }
        [Column("passcrypt")]
        public string Passcrypt { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("isActivated")]
        public bool IsActivated { get; set; } = false;
    }
}
