using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestAssignmentLP.Models;

namespace TestAssignmentLP.Models
{
    public class DbInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext db)
        {
            /*db.Shops.Add(new Shop {Name = "MSI", Address = "qwert", Shedule = "9.00-20.00"});
            db.Shops.Add(new Shop { Name = "Acer", Address = "qwert", Shedule = "9.00-20.00" });
            db.Shops.Add(new Shop { Name = "GIGABYTE", Address = "qwert", Shedule = "9.00-20.00" });

            db.Products.Add(new Product {Name = "GX 980", Description = "NVIDIA Card"});
            db.Products.Add(new Product { Name = "GT 970", Description = "NVIDIA Card" });
            db.Products.Add(new Product { Name = "RX 480", Description = "AMD Card" });
            db.Products.Add(new Product { Name = "Emachnies E732G", Description = "Acer Notebook" });
            db.Products.Add(new Product { Name = "GE62", Description = "MSI Notebook" });

            base.Seed(db);*/

            Product p11 = new Product { Name = "GX 980", Description = "NVIDIA Card" };
            Product p12 = new Product { Name = "GT 970", Description = "NVIDIA Card" };
            Product p13 = new Product { Name = "RX 480", Description = "AMD Card" };
            Product p14 = new Product { Name = "Emachnies E732G", Description = "Acer Notebook" };
            Product p15 = new Product { Name = "GE62", Description = "MSI Notebook" };
            db.Products.AddRange(new List<Product> {p11, p12, p13, p14, p15});
            db.SaveChanges();

            Shop s1 = new Shop { Name = "MSI", Address = "901 Canada Court, City of Industry", Shedule = "9.00-20.00" };
            s1.Products.Add(p11);
            s1.Products.Add(p15);
            Shop s2 = new Shop { Name = "Acer", Address = "19 Prospect Hill Rd, Camberwell VIC 3124", Shedule = "9.00-20.00" };
            s2.Products.Add(p12);
            s2.Products.Add(p14);
            Shop s3 = new Shop { Name = "GIGABYTE", Address = "No.6, Baoqiang Rd., Xindian Dist", Shedule = "9.00-20.00" };
            s3.Products.Add(p13);
            s3.Products.Add(p12);
            s3.Products.Add(p11);
            Shop s4 = new Shop { Name = "Test", Address = "Test", Shedule = "Test" };
            db.Shops.AddRange(new List<Shop> {s1, s2, s3, s4});
            db.SaveChanges();

        }
    }
}