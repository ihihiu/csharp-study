using System;
using System.Collections;
using static System.Console;

namespace TestEvent
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                WriteLine("-------------");
                WriteLine("{0} : 짝!!!", number);
            }
        }
    }
    class Program
    {   
        static public void MyHandler(string message)
        {
            WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier myNotifier = new MyNotifier();
            myNotifier.SomethingHappened += new EventHandler(MyHandler);
            for(int i = 1; i < 30; i++)
            {
                myNotifier.DoSomething(i);
            }
        }

    }
}