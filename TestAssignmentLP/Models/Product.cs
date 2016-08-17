﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAssignmentLP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Shop> Shops { get; set; } 

        public Product()
        {
            Shops = new List<Shop>();
        }
    }
}