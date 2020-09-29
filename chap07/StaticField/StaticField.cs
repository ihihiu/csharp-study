using System;
using static System.Console;

namespace StaticField
{
    class Program
    {
        class Global
        {
            public static int Count = 0;
        }
        class ClassA
        {
            public ClassA()
            {
                Global.Count++;
            }
        }
        class ClassB
        {
            public ClassB()
            {
                Global.Count++;
            }
        }

        static void Main(string[] args)
        {
            WriteLine($"Global.Count : {Global.Count}");

            ClassA a = new ClassA(); //클래스 ClassA의 객체 instance를 힙 영역에 생성하고, 그 참조형 변수로 a에 주소를 저장
                                     //클래스 ClassA를 자료형으로 가지는 참조형 변수 a
            ClassA b = new ClassA(); //클래스 ClassA의 객체 instance를 힙 영역에 생성하고, 그 참조형 변수로 b에 주소를 저장
                                     //클래스 ClassA를 자료형으로 가지는 참조형 변수 b
            ClassB c = new ClassB(); //클래스 ClassB의 객체 instance를 힙 영역에 생성하고, 그 참조형 변수로 c에 주소를 저장
                                     //클래스 ClassB를 자료형으로 가지는 참조형 변수 c
            ClassB d = new ClassB(); //클래스 ClassB의 객체 instance를 힙 영역에 생성하고, 그 참조형 변수로 d에 주소를 저장
                                     //클래스 ClassB를 자료형으로 가지는 참조형 변수 d

            WriteLine($"Global.Count : {Global.Count}");
        }
    }
}