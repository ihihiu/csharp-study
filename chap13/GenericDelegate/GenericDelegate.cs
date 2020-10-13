using System;
using System.Collections;
using static System.Console;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b); //결과값은 int

    class Program
    {
        static int AscendCompare<T>(T a, T b) where T :IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T :IComparable<T>
        {
            return a.CompareTo(b)*(-1);
        }
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i, j;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - 1; j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        T temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();
            BubbleSort<int>(array, new Compare<int>(AscendCompare));
            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();

            int[] array2 = { 3, 7, 4, 2, 10 };
            for (int i = 0; i < array2.Length; i++)
                Write($"{array2[i]} ");
            WriteLine();
            BubbleSort<int>(array2, new Compare<int>(DescendCompare));
            for (int i = 0; i < array2.Length; i++)
                Write($"{array2[i]} ");
            WriteLine();

            string[] array3 = { "abc", "def", "abf", "defg", "xyz" };
            BubbleSort<string>(array3, new Compare<string>(AscendCompare));

            for (int i = 0; i < array3.Length; i++)
                Write($"{array3[i]} ");
            WriteLine();

            BubbleSort<string>(array3, new Compare<string>(DescendCompare));
            for (int i = 0; i < array3.Length; i++)
                Write($"{array3[i]} ");
            WriteLine();

        }

    }
}