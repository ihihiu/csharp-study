using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace UsingGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                WriteLine(stack.Pop());
        }
    }
}