using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace UsingParms
{
    class Program
    {
        static int Sum(params int[] args)
        {
            Write("Summing... ");

            int sum = 0;
            
            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Write(", ");

                Write(args[i]);

                sum += args[i];
            }
            WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            WriteLine($"Sum : {sum}");

        }
    }
}