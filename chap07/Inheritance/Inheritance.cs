using System;
using System.Xml.Serialization;
using static System.Console;

namespace Inheritance
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            WriteLine($"{this.Name}.~Base()");
        }
        public void BaseMethod()
        {
            WriteLine($"{Name}.BaseMethod()");
        }
    }
    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            WriteLine($"{this.Name}.DerivedMethod()");
        }
        public void DerivedMethod()
        {
            WriteLine($"{Name}.DerivedMethod()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
