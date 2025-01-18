namespace ConsoleAppHW7PETSHOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            var shop = new PetShop();

           
            shop.AddProduct(new PetFood(1, "Корм сухой", 500, 20, "собаки"));
            shop.AddProduct(new PetFood(2, "Корм влажный", 600, 20, "собаки"));
            shop.AddProduct(new PetFood(3, "Корм сухой", 700, 20, "коты"));
            shop.AddProduct(new PetFood(4, "Корм влажный", 800, 20, "влажный"));
            shop.AddProduct(new PetToy(5, "Мячик для кошек", 150, 50, "резина"));
            shop.AddProduct(new PetToy(6, "Мячик для собак", 150, 50, "резина"));
            shop.AddProduct(new PetToy(7, "Кость для собак", 350, 45, "резина"));
            shop.AddProduct(new PetToy(8, "Клубок для кошек", 200, 30, "акрил"));
            shop.AddProduct(new PetToy(9, "Мышь для кошек", 250, 50, "резина"));

            bool shopping = true;

            while (shopping)
            {
               
                shop.DisplayProducts();

                Console.WriteLine("\nВведите ID товара, который вы хотите купить (или 0 для выхода):");

                
                if (!int.TryParse(Console.ReadLine(), out int productId))
                {
                    Console.WriteLine("Ошибка: введите корректное число!");
                    continue;
                }

                if (productId == 0)
                {
                    Console.WriteLine("Спасибо за посещение магазина!");
                    shopping = false;
                    continue;
                }

               
                var product = shop.Products.Find(p => p.Id == productId);
                if (product == null)
                {
                    Console.WriteLine("Товар с таким ID не найден.");
                    continue;
                }

                Console.WriteLine($"Вы выбрали: {product.Name}. Сколько штук вы хотите купить?");

                
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Ошибка: введите корректное число!");
                    continue;
                }

                try
                {
                    product.ReduceStock(quantity);
                    Console.WriteLine($"Вы купили {quantity} шт. товара \"{product.Name}\". Осталось на складе: {product.Stock} шт.\n");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("Хотите продолжить покупки? (да/нет (любую другую клавишу)):");
                string answer = Console.ReadLine().ToLower();
                if (answer != "да")
                {
                    shopping = false;
                    Console.WriteLine("Спасибо за посещение магазина!");
                }
            }
         }
    }
}



    

