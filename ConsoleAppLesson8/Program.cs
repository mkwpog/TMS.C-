namespace ConsoleAppLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя собаки:");
            string dogName = Console.ReadLine();

            Dog myDog = new Dog();

            myDog.SetName(dogName);

            Console.WriteLine($"Имя вашей собаки: {myDog.GetName()}");
            myDog.Eat();

            
        }
    
    }
}
