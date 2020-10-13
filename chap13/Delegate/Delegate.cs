using System;
using static System.Console;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);
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
            MyDelegate Callback = new MyDelegate(Calculator.Plus);
            WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            WriteLine(Callback(3, 4));

        }
    }
}