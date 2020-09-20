using System;
using static System.Console;

namespace GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("종료 조건(숫자)를 입력하세요 : ");

            string input = ReadLine();

            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            for (int i = 0;i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for(int k = 0; k< 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

            EXIT_FOR:
                WriteLine("\nExit nested for...");

            EXIT_PROGRAM:
                WriteLine("Exit program...");

        }
    }
}
