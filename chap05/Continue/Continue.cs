using System;
using static System.Console;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10;i++)
            {
                if (i % 2 == 0)
                    continue;

                WriteLine($"{i} : 홀수");
            }
        }
    }
}
