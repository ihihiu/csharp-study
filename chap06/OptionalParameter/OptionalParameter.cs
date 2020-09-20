using System;
using static System.Console;

namespace OptioonalParameter
{
    class Program
    {
        static void PrintProfile(string name, string phone="")
        {
            WriteLine($"Name : {name}, Phone : {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아","010-123-1234");
            PrintProfile(name: "유리");
            PrintProfile(name:"서현", phone: "010-789-7890");

        }
    }
}