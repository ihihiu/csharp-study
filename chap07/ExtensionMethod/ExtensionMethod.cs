using System;
using static System.Console;
using MyExtension; //확장 메소드를 담는 클래스의 네임스페이스를 사용

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;

            return result;
        }
    }
}
namespace ExtensionMethod 
{ 
        class Program
        {
            static void Main(string[] args)
            {
                WriteLine($"3^2 : {3.Square()}");
                WriteLine($"3^4 : {3.Power(4)}");
                WriteLine($"2^10 : {2.Power(10)}");
            }
        }
}