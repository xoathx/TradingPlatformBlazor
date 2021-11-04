using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformBlazor.Data.Models
{
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nameCategory")]
        public string NameCategory { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}
