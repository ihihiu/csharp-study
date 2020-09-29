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
            //public int CatCount=0; //인스턴스 변수
            public static int CatCount = 0; //클래스 변수
            public Cat() //생성자
            {
                Name = "default";
                Color = "default";
                CatCount++;
            }
            public Cat(string _Name, string _Color)
            {
                Name = _Name;
                Color = _Color;
                CatCount++;
            }
            public Cat(string _Name)
            {
                Name = _Name;
                Color = "";
                CatCount++;
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
            kitty.Color = "하얀색";
            kitty.Name = "키티";
         
            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            //WriteLine($"nero.CatCount : {nero.CatCount}");
            WriteLine($"Cat.CatCount : {Cat.CatCount}");

        }
    }
}