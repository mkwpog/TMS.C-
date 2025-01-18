using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHW7PETSHOP
{
    public class PetFood : Product
    {
        public string AnimalType { get; set; } 

        public PetFood(int id, string name, decimal price, int stock, string animalType)
            : base(id, name, price, stock)
        {
            AnimalType = animalType;
        }

        public override string GetDescription()
        {
            return $"Корм для {AnimalType}: {Name}, цена: {Price}, в наличии: {Stock} шт.";
        }
    }
}
