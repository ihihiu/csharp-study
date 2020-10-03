using System;
using static System.Console;

namespace PropertiesInInterface
{
    interface INameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }
    class NamedValue : INameValue
    {   
        public string Name { get; set; }
        public string Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "박상현"};
            NamedValue height = new NamedValue()
            { Name = "키", Value = "177Cm" };
            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "90Kg" };
            WriteLine($"{name.Name} : {name.Value}");
            WriteLine($"{height.Name} : {height.Value}");
            WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}