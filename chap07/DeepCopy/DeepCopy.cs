using System;
using static System.Console;

namespace DeepCopy
{
    class MyClass 
    {
        public int myNum1;
        public int myNum2;

        public MyClass DeepCopy()
        {
            MyClass m = new MyClass();
            m.myNum1 = myNum1;
            m.myNum2 = myNum2;
            return m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass num1 = new MyClass();
            num1.myNum1 = 10;
            num1.myNum2 = 20;

            MyClass num2;
            num2 = num1; //얕은 복사

            num2.myNum1 = 100;
            WriteLine($"num1.myNum1 : {num1.myNum1}, num1.myNum2 : {num1.myNum2}");

            //num2 = new MyClass();  // 깊은 복사
            //num2.myNum1 = num1.myNum1;
            //num2.myNum2 = num1.myNum2;

            MyClass num3;
            // num3.DeepCopy();   // 불가능 -> 참조형 변수 num3가 아무것도 가리키지 않고 있기 때문
            num3 = num1.DeepCopy(); //깊은 복사
            num3.myNum1 = 1000;
            WriteLine($"num1.myNum1 : {num1.myNum1}, num1.myNum2 : {num1.myNum2}");

        }
    }
}