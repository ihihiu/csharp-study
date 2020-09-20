using System;
using static System.Console;

namespace Overloading
{
    class Program
    {
        static int Plus(int a, int b)
        {
            WriteLine("Calling int Plus(int,int)...");
            return a + b;
        }
        static int Plus(int a, int b,int c)
        {
            WriteLine("Calling int Plus(int,int,int)...");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            WriteLine("Calling double Plus(double,double)...");
            return a + b;
        }
        static double Plus(int a, double b)
        {
            WriteLine("Calling double Plus(int,double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            WriteLine(Plus(1, 2));
            WriteLine(Plus(1, 2, 3));
            WriteLine(Plus(1.0, 2.4));
            WriteLine(Plus(1, 2.4));

        }
    }
}