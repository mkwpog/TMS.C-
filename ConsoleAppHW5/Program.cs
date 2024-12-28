using System.Text.RegularExpressions;

namespace ConsoleAppHW5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку текста:"); //pull
            string input = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Найти слова с максимальным количеством цифр.");
                Console.WriteLine("2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
                Console.WriteLine("3. Заменить цифры от 0 до 9 на слова.");
                Console.WriteLine("4. Вывести вопросительные и восклицательные предложения.");
                Console.WriteLine("5. Вывести предложения без запятых.");
                Console.WriteLine("6. Найти слова, начинающиеся и заканчивающиеся на одну букву.");
                Console.WriteLine("0. Выход.");

                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WordsWithMaxDigits(input);
                        break;
                    case "2":
                        LongestWord(input);
                        break;
                    case "3":
                        ReplaceDigitsWithWords(input);
                        break;
                    case "4":
                        QuestionAndExclamationSentences(input);
                        break;
                    case "5":
                        SentencesWithoutCommas(input);
                        break;
                    case "6":
                        WordsStartingAndEndingWithSameLetter(input);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void WordsWithMaxDigits(string input) // классы подсмотрел не сам делал
        {
            var words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int maxDigits = words.Max(w => w.Count(char.IsDigit));
            var result = words.Where(w => w.Count(char.IsDigit) == maxDigits);

            Console.WriteLine("Слова с максимальным количеством цифр:");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        static void LongestWord(string input)
        {
            var words = input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = words.Max(w => w.Length);
            var longestWords = words.Where(w => w.Length == maxLength);
            var mostFrequent = longestWords.GroupBy(w => w).OrderByDescending(g => g.Count()).FirstOrDefault();

            Console.WriteLine($"Самое длинное слово: {mostFrequent.Key}, встретилось {mostFrequent.Count()} раз(а).");
        }

        static void ReplaceDigitsWithWords(string input)
        {
            string[] digitWords = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string result = Regex.Replace(input, "\\d", match => digitWords[int.Parse(match.Value)]);

            Console.WriteLine("Текст с заменёнными цифрами:");
            Console.WriteLine(result);
        }

        static void QuestionAndExclamationSentences(string input)
        {
            var sentences = Regex.Split(input, "(?<=[.!?])").Select(s => s.Trim());
            var questions = sentences.Where(s => s.EndsWith("?"));
            var exclamations = sentences.Where(s => s.EndsWith("!"));

            Console.WriteLine("Вопросительные предложения:");
            foreach (var sentence in questions)
            {
                Console.WriteLine(sentence);
            }

            Console.WriteLine("Восклицательные предложения:");
            foreach (var sentence in exclamations)
            {
                Console.WriteLine(sentence);
            }
        }

        static void SentencesWithoutCommas(string input)
        {
            var sentences = Regex.Split(input, "(?<=[.!?])").Select(s => s.Trim());
            var noCommaSentences = sentences.Where(s => !s.Contains(","));

            Console.WriteLine("Предложения без запятых:");
            foreach (var sentence in noCommaSentences)
            {
                Console.WriteLine(sentence);
            }
        }

        static void WordsStartingAndEndingWithSameLetter(string input)
        {
            var words = input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Where(w => w.Length > 1 && char.ToLower(w.First()) == char.ToLower(w.Last()));

            Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну букву:");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}






