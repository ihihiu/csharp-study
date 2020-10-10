using System;
using static System.Console;

namespace MoreOnArray
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Write($"{score} ");
            WriteLine();

            Array.Sort(scores); //오름차순으로 정렬
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            WriteLine($"Number of dimensions : {scores.Rank}"); //배열의 차원을 반환

            WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81)); //이진 탐색
            WriteLine("Linear Search : 90 is at {0}", Array.IndexOf(scores, 90)); //인덱스 반환

            WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed)); //배열의 값이 60이 넘는지 CheckPassed로 확인 
                                                                                              // 60 미만이 하나라도 있으면 false
            int index = Array.FindIndex<int>(scores,    //조건에 부합하는 첫 번째 요소의 인덱스를 반환
                delegate (int score)
                {
                    if (score < 60)
                        return true;
                    else
                        return false;
                });
            WriteLine($"{index}, {scores[index]}");

            scores[index] = 61; // 34 => 61
            WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            WriteLine($"Old length of scores : {scores.GetLength(0)}"); //배열에서 지정한 차원의 길이 반환

            Array.Resize<int>(ref scores, 10); //배열의 용량을 10으로 재조정
            WriteLine($"New length of scores : {scores.GetLength(0)}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            Array.Clear(scores, 3, 7); //인덱스 3부터 7개의 요소를 초기화. int 형식이므로 0으로 초기화

            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();
        }
    }
}