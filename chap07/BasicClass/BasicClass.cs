using System;
using static System.Console;

namespace BasicClass
{
    class Program
    {
        class Cat
        {
            public string Name;
            public string Color;
            public void Meow()
            {
                WriteLine($"{Name} : 야옹");
            }
        }
        
        static void Main(string[] args)
        {
            Cat kitty;
            kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}