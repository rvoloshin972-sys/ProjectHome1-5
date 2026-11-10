using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome1
{
    public class NumberGenerator
    {
        private Random random = new Random();
        public List<int> GenerateNumbers(int count)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(1, 1001));
            }
            return numbers;
        }
        public bool IsPrime(int number)
        {
            return number > 1 &&
                Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                .All(divisor => number % divisor != 0);
        }
        public List<int> GetFibonacciNumbers(List<int> numbers)
        {
            int maxNumber = numbers.Max();
            HashSet<int> fibonacci = new HashSet<int>();

            int previous = 0;
            int current = 1;

            while (current <= maxNumber)
            {
                fibonacci.Add(current);
                (previous, current) = (current, previous + current);
            }
            return numbers
                .Where(number => fibonacci.Contains(number))
                .ToList();
        }
    }
}
