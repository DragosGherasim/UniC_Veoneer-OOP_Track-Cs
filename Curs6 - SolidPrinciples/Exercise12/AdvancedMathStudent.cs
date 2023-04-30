using System;

namespace Exercise12
{
    internal class AdvancedMathStudent
    {
        private AdvancedCalculator _calculator;

        public AdvancedMathStudent()
        {
            _calculator = new AdvancedCalculator();
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
                case "power":
                    return _calculator.Power(number1, number2);
                case "squareroot":
                    return _calculator.SquareRoot(number1);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
