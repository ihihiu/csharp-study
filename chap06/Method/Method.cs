using System;
using static System.Console;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4);
            WriteLine(result);

            result = Calculator.Minus(5, 2);
            WriteLine(result);

        }
    }
}
