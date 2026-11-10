namespace ProjectHome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            NumberGenerator generator = new NumberGenerator();
            FileManager fileManager = new FileManager();

            List<int> numbers = generator.GenerateNumbers(100);

            List<int> primeNumbers = numbers
                .Where(number => generator.IsPrime(number))
                .ToList();

            List<int> fibonacciNumbers = generator.GetFibonacciNumbers(numbers);

            fileManager.SaveNumbers("PrimeNumbers.txt", primeNumbers);
            fileManager.SaveNumbers("FibonacciNumbers.txt", fibonacciNumbers);
            fileManager.ReadNumbers("PrimeNumbers.txt");
            fileManager.ReadNumbers("FibonacciNumbers.txt");

            Console.WriteLine("\n СТАТИСТИКА РОБОТИ ");
            Console.WriteLine($"Згенеровано чисел: {numbers.Count}");
            Console.WriteLine($"Простих чисел: {primeNumbers.Count}");
            Console.WriteLine($"Чисел Фібоначчі: {fibonacciNumbers.Count}");
            Console.WriteLine($"Загальна кількість записів у файлах: " + $"{primeNumbers.Count + fibonacciNumbers.Count}");
            Console.WriteLine("\nРоботу програми завершено!");


        }
    }
}
