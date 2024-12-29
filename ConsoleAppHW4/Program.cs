namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы (строки и столбцы):");
            Console.Write("Количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Ввод элементов матрицы
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Вывести матрицу");
                Console.WriteLine("2. Найти количество положительных/отрицательных чисел");
                //Console.WriteLine("3. Сортировка элементов матрицы построчно");
                // Console.WriteLine("4. Инверсия элементов матрицы построчно");
                Console.WriteLine("5. Выйти");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintMatrix(matrix);
                        break;
                    case 2:
                        CountPositiveNegative(matrix);
                        break;

                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }

        static void CountPositiveNegative(int[,] matrix)
        {
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (var element in matrix)
            {
                if (element > 0)
                    positiveCount++;
                else if (element < 0)
                    negativeCount++;
            }

            Console.WriteLine($"Положительных чисел: {positiveCount}");
            Console.WriteLine($"Отрицательных чисел: {negativeCount}");
        }


    }
}
