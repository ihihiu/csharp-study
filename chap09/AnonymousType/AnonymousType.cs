using System;
using static System.Console;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Write($"Subject : {b.Subject}, Socres : ");
            foreach (var score in b.Scores)
                Write($"{score} ");

            WriteLine();
        }
    }
}