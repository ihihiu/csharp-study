using System;
using static System.Console;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA() 
        {
            WriteLine("AbstractBase.PrivateMethodA()"); 
        }
        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA() 
        {
            WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}