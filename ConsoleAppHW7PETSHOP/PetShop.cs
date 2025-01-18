using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHW7PETSHOP
{
    public class PetShop
    {
        public List<Product> Products { get; private set; }

        public PetShop()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Товары в зоомагазине:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Id}. {product.GetDescription()}");
            }
        }
    }
}
