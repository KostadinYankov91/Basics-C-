﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Dtos.Inputs
{
    public class ProductInputDto
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
        public int? BuyerId { get; set; }
    }
}
