using System;
using static System.Console;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
                WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            double average = (double)sum / scores.Length;
            WriteLine($"Average Score : {average}");
        }
    }
}