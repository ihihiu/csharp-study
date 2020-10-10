using System;
using static System.Console;
using System.Collections;

namespace UsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            stack.Push("e");

            while (stack.Count > 0)
                WriteLine(stack.Pop());
        }
    }
}