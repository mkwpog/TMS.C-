using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHW7PETSHOP
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    
     protected Product(int id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
        public abstract string GetDescription();

        public void ReduceStock(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
            }
            else
            {
                throw new InvalidOperationException("Недостаточно товара на складе.");
            }
        }
    }

}
