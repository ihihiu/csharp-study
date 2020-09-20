using System;
using static System.Console;

namespace SwapByValue
{

    class Program
    {
       public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;

        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            WriteLine($"x : {x}, y : {y}");

            Swap(x, y);

            WriteLine($"x : {x}, y : {y}");

        }
    }
}
