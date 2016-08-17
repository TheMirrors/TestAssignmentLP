using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAssignmentLP.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}