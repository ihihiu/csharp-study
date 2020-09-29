using static System.Console;

namespace MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            WriteLine("Base.MyMethod()");
        }
    }
    class Derived : Base
    {
        public new void MyMethod() //Base.MyMethod()를 감추고 Derived 클래스에서 구현된 MyMethod()만 노출
        {
            WriteLine("Derived.MyMethod()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }



}