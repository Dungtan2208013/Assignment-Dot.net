﻿using Shopping.Models;

namespace Shopping.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Product? Product { get; set; }

        public int Quantity
        {
            get; set;
        }
    }
}