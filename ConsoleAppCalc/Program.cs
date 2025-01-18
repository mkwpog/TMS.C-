namespace Lesson3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("imput a:");
            var valid1 = decimal.TryParse(Console.ReadLine(), out var value1);
            if (valid1 == false)
            {
                Console.WriteLine($"invalid a: {value1}");
                return;
            }
            Console.Write("imput b:");
            var valid2 = decimal.TryParse(Console.ReadLine(), out var value2);
            if (valid2 == false)
            {
                Console.WriteLine($"Invalid b: {value2}");
                return;
            }

            Console.Write("imput percent from a:");
            var valid3 = int.TryParse(Console.ReadLine(), out var value3);
            if (valid3 != value3 > 0 && value3 <= 100)
            {
                Console.WriteLine($"Invalid percent: {value3}");
                return;
            }

            Console.Write("imput c:");
            var valid4 = int.TryParse(Console.ReadLine(), out var value4);

            if (valid4 != value4 > 0)
            {
                Console.WriteLine($"Invalid c: {value4}");
                return;
            }

            Console.Write("imput operation: [+],[-],[/],[*],[p],[sqrt] :");
            var operation = Console.ReadLine();
            object res = operation switch
            {

                "+" => value1 + value2,
                "-" => value1 - value2,
                "/" => value1 / value2,
                "*" => value1 * value2,
                "p" => value1 * value3/100,
                "sqrt" => Math.Sqrt(value4),


                _ => throw new NotImplementedException(),
            };



            Console.WriteLine(res);
            Console.ReadLine(); //pull request

        }
    }
}