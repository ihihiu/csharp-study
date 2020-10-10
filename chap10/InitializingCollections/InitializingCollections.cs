using System;
using static System.Console;
using System.Collections;

namespace InitializingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr); //매개 변수로 배열 객체를 넘겨 해당 배열을 바탕으로 초기화
            foreach (object item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue que = new Queue(arr);
            foreach (object item in que)
                WriteLine($"Queue : {item}");
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 }; //컬렉션 초기자를 이용
            foreach (object item in list2)
                WriteLine($"ArrayList2 : {item}");
            WriteLine();

        }
    }
}