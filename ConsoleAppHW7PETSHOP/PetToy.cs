using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHW7PETSHOP
{
    public class PetToy : Product //pull
    {
        public string Material { get; set; }

        public PetToy(int id, string name, decimal price, int stock, string material)
            : base(id, name, price, stock)
        {
            Material = material;
        }

        public override string GetDescription()
        {
            return $"Игрушка: {Name}, материал: {Material}, цена: {Price}, в наличии: {Stock} шт.";
        }
    }
}
