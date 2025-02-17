﻿using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Dto
{
    public class ViewMyProduct
    {
        public int ProductId { get; set; }
        public int CartId { get; set; } = 1;
        public string ProductName { get; set; } = String.Empty;

        public string ProductDescription { get; set; } = String.Empty;
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
