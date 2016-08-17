using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAssignmentLP.Models
{
    public class ShopRepository : IRepository<Shop>
    {
        private ShopContext db;

        public ShopRepository(ShopContext context)
        {
            this.db = context;
        }

        public void Create(Shop shop)
        {
            db.Shops.Add(shop);
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);
            if (shop != null)
                db.Shops.Remove(shop);
        }

        public Shop Find(int id)
        {
            return db.Shops.Find(id);
        }

        public IEnumerable<Shop> ReadAll()
        {
            return db.Shops;
        }
    }

    public class ProductRepository : IRepository<Product>
    {
        private ShopContext db;

        public ProductRepository(ShopContext context)
        {
            this.db = context;
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        public Product Find(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> ReadAll()
        {
            return db.Products;
        }
    }
}