using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12
{
    internal interface ICalculator
    {
        int Add(int number1, int number2);
        int Subtract(int number1, int number2);
        int Multiply(int number1, int number2);
        double Divide(int number1, int number2);
        double Power(double number1, double number2);
        double SquareRoot(double number);

    }
}
