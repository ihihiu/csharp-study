﻿using System;
using static System.Console;

namespace DerivedFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            WriteLine($"Type of array : {array.GetType()}");
            WriteLine($"Base type of array : {array.GetType().BaseType}");
        }
    }
}