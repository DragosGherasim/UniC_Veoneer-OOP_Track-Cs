using System;

namespace Exercise12
{
    internal class BasicMathStudent
    {
        private BasicCalculator _calculator;

        public BasicMathStudent()
        {
            _calculator = new BasicCalculator();
        }

        public double Calculate(string operation, int number1, int number2)
        {
            switch (operation)
            {
                case "add":
                    return _calculator.Add(number1, number2);
                case "subtract":
                    return _calculator.Subtract(number1, number2);
                case "multiply":
                    return _calculator.Multiply(number1, number2);
                case "divide":
                    return _calculator.Divide(number1, number2);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
