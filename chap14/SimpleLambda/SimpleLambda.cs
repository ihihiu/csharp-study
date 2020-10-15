using System;
using System.Collections;
using static System.Console;

namespace SimpleLambda
{
    class Program
    {
        delegate int Calculate(int a, int b);
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //기본적인 delegate 사용법
            Calculate calc = new Calculate(Plus);
            WriteLine(calc(4, 5));
            
            //익명의  delegate
            calc = delegate (int a, int b)
                    {
                        return b - a;
                    };
            WriteLine(calc(7, 5));

            //람다식으로 표현(무명 delegate)
            calc = (a,b) => a * b;
            WriteLine(calc(3, 4));
        }

    }
}