using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Models;

namespace TradingPlatformBlazor.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopLot> ShopLots { get; set; }
        public DbSet<MessageShop> MessageShops { get; set; }
        public DbSet<AccessToken> AccessTokens { get; set; }
    }
}
