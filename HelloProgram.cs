using System;
using static System.Console;
namespace ConsoleApp1
{ 

    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                WriteLine("Enter args....");
                return;
            }
            else
            {
                WriteLine("Hello {0}", args[0]);
                return;
            }
            
        }
    }
}
