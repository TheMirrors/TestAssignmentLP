using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAssignmentLP.Models
{
    public class UnitOfWork : IDisposable
    {
        private ShopContext db = new ShopContext();
        private ShopRepository shopRepository;
        private ProductRepository productRepository;

        public ShopRepository Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(db);
                return shopRepository;
            }
        }

        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}