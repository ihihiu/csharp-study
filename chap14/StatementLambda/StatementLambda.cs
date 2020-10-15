using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace StatementLambda
{
    class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concatenate = (arr) =>
                                     {
                                         string result = "";
                                         foreach (string s in arr)
                                             result += s;
                                         return result;
                                     };
            WriteLine(concatenate(args));
        }

    }
}