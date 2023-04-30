using System;

namespace Example11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            SumCalculator sum = new SumCalculator(numbers);
            var result = sum.Calculate();

            Console.WriteLine(result);

            EventNumbersSumCalculator evenSum = new EventNumbersSumCalculator(numbers);
            result = evenSum.Calculate();

            Console.WriteLine(result);

            SumCalculator evenSum1 = new EventNumbersSumCalculator(numbers);
            result = evenSum1.Calculate();

            Console.WriteLine(result);
        }
    }
}
