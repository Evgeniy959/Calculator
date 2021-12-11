using System;
using System.Runtime.CompilerServices;

namespace CalculatorLib
{
    public static class Calculator
    {
        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public static double Mult(double x, double y) => x * y;

        public static double Div(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя!");
            }

            return x / y;
        }
    }
}