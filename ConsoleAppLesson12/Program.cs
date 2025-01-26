namespace ConsoleAppLesson12
{
    public class Program
    {
        public class MyStack<T> //pull
        {
            public List<T> _items; 

            public MyStack()
            {
                _items = new List<T>();
            }

            
            public void Push(T item)
            {
                _items.Add(item);
            }

            
            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Стек пуст");
                }

                T topItem = _items[_items.Count - 1];
                _items.RemoveAt(_items.Count - 1);
                return topItem;
            }

            
            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Стек пуст");
                }

                return _items[_items.Count - 1];
            }

           
            public bool IsEmpty()
            {
                return _items.Count == 0;
            }
        }

        static void Main(string[] args)
        {
            // стек для целых чисел
            MyStack<int> intStack = new MyStack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            Console.WriteLine($"Верхний элемент стека (Peek): {intStack.Peek()}");
            Console.WriteLine($"Удаляем верхний элемент (Pop): {intStack.Pop()}");
            Console.WriteLine($"Верхний элемент после удаления (Peek): {intStack.Peek()}");
            Console.WriteLine($"Стек пуст? {intStack.IsEmpty()}");

            Console.WriteLine();

            // стек для строк
            MyStack<string> stringStack = new MyStack<string>();
            stringStack.Push("Tom");
            stringStack.Push("Bob");
            stringStack.Push("Jerax");
            Console.WriteLine($"Верхний элемент стека (Peek): {stringStack.Peek()}");
            Console.WriteLine($"Удаляем верхний элемент (Pop): {stringStack.Pop()}");
            Console.WriteLine($"Верхний элемент после удаления (Peek): {stringStack.Peek()}");
            Console.WriteLine($"Стек пуст? {stringStack.IsEmpty()}");
        }
    }
}
