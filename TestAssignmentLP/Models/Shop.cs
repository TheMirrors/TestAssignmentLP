using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAssignmentLP.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Shedule { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}