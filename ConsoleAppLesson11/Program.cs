namespace ConsoleAppLesson11
{
    public enum Operation //Pull
    {
        Sum,
        Subtract,
        Multiply
    }

    public class OperationManager
    {
        private int _first;
        private int _second;

        public OperationManager(int first, int second)
        {
            _first = first;
            _second = second;
        }

        public int Sum() => _first + _second;

        public int Subtract() => _first - _second;

        public int Multiply() => _first * _second;
    }

    // Implement functionality using Func delegates
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; } = new Dictionary<Operation, Func<int>>();

        public void PopulateFunctions(OperationManager opManager)
        {
            // Register delegates for operations
            FuncExecute[Operation.Sum] = opManager.Sum;
            FuncExecute[Operation.Subtract] = opManager.Subtract;
            FuncExecute[Operation.Multiply] = opManager.Multiply;
        }

        public int Execute(Operation operation)
        {
            if (FuncExecute.TryGetValue(operation, out var func))
            {
                return func();
            }

            throw new InvalidOperationException("Operation not supported");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var opManager = new OperationManager(20, 10);
            var execManager = new ExecutionManager();

            // Populate the dictionary with delegates
            execManager.PopulateFunctions(opManager);

            // Execute operations
            int sumResult = execManager.Execute(Operation.Sum);
            Console.WriteLine($"The result of Sum is {sumResult}");

            int subtractResult = execManager.Execute(Operation.Subtract);
            Console.WriteLine($"The result of Subtract is {subtractResult}");

            int multiplyResult = execManager.Execute(Operation.Multiply);
            Console.WriteLine($"The result of Multiply is {multiplyResult}");

            Console.ReadKey();
        }
    }
}
