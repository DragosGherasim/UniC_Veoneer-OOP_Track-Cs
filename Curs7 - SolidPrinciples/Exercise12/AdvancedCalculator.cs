using System;
using Exercise12;

namespace Exercise12
{
    internal class AdvancedCalculator : IArithmetic, IExponents
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
