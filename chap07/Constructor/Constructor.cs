using System;
using static System.Console;

namespace Constructor
{
    class Program
    {
        class Cat
        {
            public string Name;
            public string Color;
            public Cat() //생성자
            {
                Name = "default";
                Color = "default";
            }
            public Cat(string _Name, string _Color)
            {
                Name = _Name;
                Color = _Color;
            }
            public Cat(string _Name)
            {
                Name = _Name;
                Color = "";
            }
            public void Meow()
            {
                WriteLine($"{Name} : 야옹");
            }
            ~Cat()
            {
                WriteLine($"{Name} : 잘가");
            }
            
        }
        
        static void Main(string[] args)
        {
            Cat kitty,kitty2;
            kitty = new Cat("Yaong","Blue");
            kitty2 = new Cat("Yaong");
            kitty.Meow();
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