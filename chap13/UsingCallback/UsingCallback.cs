using System;
using static System.Console;

namespace UsingCallback
{
    delegate int Compare(int a, int b);
 
    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet,Compare Comparer)
        {
            int i, j;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - 1; j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        int temp = DataSet[j];
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
            BubbleSort(array, new Compare(AscendCompare));
            for (int i = 0; i < array.Length; i++)
                Write($"{array[i]} ");
            WriteLine();

            int[] array2 = { 3, 7, 4, 2, 10 };
            for (int i = 0; i < array2.Length; i++)
                Write($"{array2[i]} ");
            WriteLine();
            BubbleSort(array2, new Compare(DescendCompare));
            for (int i = 0; i < array2.Length; i++)
                Write($"{array2[i]} ");
        }
    }
}