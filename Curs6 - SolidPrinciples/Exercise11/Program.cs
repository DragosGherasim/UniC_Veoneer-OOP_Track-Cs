using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Calculator sum = new SumCalculator(numbers);
            var result = sum.Calculate();
            Console.WriteLine(result);

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            result = evenSum.Calculate();

            Console.WriteLine(result);
        }
    }
}
