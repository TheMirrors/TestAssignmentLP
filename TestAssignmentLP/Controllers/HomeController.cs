using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAssignmentLP.Models;
using System.Data.SqlClient;

namespace TestAssignmentLP.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ShopContext dbs = new ShopContext();
           /* IEnumerable<Shop> shops = db.Shops;*/
            var shops = dbs.Database.SqlQuery<Shop>("SELECT * FROM Shops");
            ViewBag.Shops = shops;
            return View();
        }

        public ActionResult Items(string sName, int id = 0)
        {
            if (id == 0)
                return View("~/Views/Shared/NotFound.cshtml");
            ShopContext dbi = new ShopContext();
            SqlParameter param = new SqlParameter("@id", id);
            var items = dbi.Database.SqlQuery<Product>("SELECT p.Id, p.Name, p.Description FROM Products p " +
                                                       "join ShopProducts sp on sp.product_id = p.id " +
                                                       "join Shops s on s.id = sp.shop_id " +
                                                       "WHERE s.Id=@id", param);
            ViewBag.Items = items;
            ViewBag.ShopName = sName;
            return PartialView();
        }

        public ActionResult WebApi()
        {
            return View();
        }
    }
}