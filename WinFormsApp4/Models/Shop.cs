﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public List<Product> Products => new List<Product>();
    }
}
