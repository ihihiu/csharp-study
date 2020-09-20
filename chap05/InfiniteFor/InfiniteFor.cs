using System;
using static System.Console;

namespace InfiniteFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
                WriteLine(i++);
        }
    }
}
