using System;
using static System.Console;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                WriteLine($"a) i : {i--}");
            }
            while (i > 0);

            do
            {
                WriteLine($"b) i : {i--}");
            }
            while (i > 0);
        }
    }
}
