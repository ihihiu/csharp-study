using System;
using static System.Console;

namespace IfIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("숫자를 입력하세요 : ");

            string input = ReadLine();
            int number = Convert.ToInt32(input);

            if(number > 0)
            {
                if (number % 2 == 0)
                    WriteLine("0보다 큰 짝수.");
                else
                    WriteLine("0보다 큰 홀수.");
            }
            else
            {
                WriteLine("0보다 작거나 같은 수.");
            }



        }
    }
}
