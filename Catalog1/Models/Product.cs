using System;

namespace Catalog1.Models
{
    public class Product
    {
        public Product(string name, int quantity, Decimal price, 
            string description)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
        }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }
    }
}