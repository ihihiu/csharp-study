using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace FuncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 20;
            WriteLine(func1());

            Func<int, int> func2 = (x) => x * 10;
            WriteLine(func2(20));

            Func<double, double, double> func3 = (x, y) => x / y;
            WriteLine(func3(1.0, 4.0));
        }

    }
}