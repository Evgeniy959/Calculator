using System;

namespace CalculatorLib.HandleTest
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            int y_error = 0;
            double res = 0;

            res = Calculator.Add(x, y);
            Console.WriteLine($"{x} + {y} = {res}");
            
            res = Calculator.Sub(x, y);
            Console.WriteLine($"{x} - {y} = {res}");
            
            res = Calculator.Mult(x, y);
            Console.WriteLine($"{x} * {y} = {res}");
            
            res = Calculator.Div(x, y);
            Console.WriteLine($"{x} / {y} = {res}");

            try
            {
                res = Calculator.Add(x, y_error);
                Console.WriteLine($"{x} + {y} = {res}");
            }
            catch (DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}