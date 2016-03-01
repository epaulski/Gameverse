using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public partial class GameverseContext : DbContext
    {
        public GameverseContext()
            : base("name=GameverseEntities")
        {
            Database.SetInitializer<GameverseContext>(new DropCreateDatabaseIfModelChanges<GameverseContext>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}