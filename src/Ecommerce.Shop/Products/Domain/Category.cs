﻿namespace Ecommerce.Shop.Products.Domain
{
    public class Category
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}