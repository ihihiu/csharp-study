using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace ActionTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;   //람다식 밖에서 선언한 result에 결과 저장
            act2(5);
            WriteLine(result);

            Action<double, double> act3 = (x, y) =>
                                                 {
                                                     double pi = x / y;
                                                     WriteLine(pi);
                                                 };
            act3(1.0, 3.0);

        }
    }
}