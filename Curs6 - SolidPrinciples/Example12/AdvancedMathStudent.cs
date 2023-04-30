using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12
{
    internal class AdvancedMathStudent
    {
        private AdvancedCalculator _calculator;

        public AdvancedMathStudent()
        {
            _calculator = new AdvancedCalculator();
        }

        public double Calculate(string operation, int number)
        {
            if (operation.ToLower() == "squareroot")
            {
                return _calculator.SquareRoot(number);
            }
            else
            {
                throw new ArgumentException();
            }
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
                default:
                    throw new ArgumentException();
            }
        }
    }
}
