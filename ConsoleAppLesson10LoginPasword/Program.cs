namespace ConsoleAppLesson10LoginPasword
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            Console.Write("Подтвердите пароль: ");
            string confirmPassword = Console.ReadLine();

            Console.WriteLine("Результат: " + ValidatorInputData.ValidateData(login, password, confirmPassword));
            Console.ReadKey();


        }
    }
}
