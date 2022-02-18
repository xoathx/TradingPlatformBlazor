using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("passcrypt")]
        public string PassCrypt { get; set; }
        [Column("nickname")]
        public string NickName { get; set; }
        [Column("dateRegistration")]
        public DateTime DateRegistration { get; set; }
        [Column("avatar")]
        public string PathAvatar { get; set; }
        [Column("role_id")]
        public UserRole Role { get; set; }
        [Column("level_user")]
        public UserLevel LevelUser { get; set; }

        [Column("balance")]
        public double Balance { get; set; }
        [Column("id_shop")]
        public int IdShop { get; set; }
        [Column("email")]
        public string Email { get; set; }
        
    }

    public enum UserRole
    {
        User,
        Administrator,
        Test,
        Banned
    }

    public enum UserLevel
    {
        First,
        Second,
        Third
    }
}
