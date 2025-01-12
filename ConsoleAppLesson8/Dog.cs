using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson8
{
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{GetName()} ест корм для собак.");
        }
    }
}
