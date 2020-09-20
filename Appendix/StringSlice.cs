using  static System.Console;

namespace StringSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Good Morning";

            WriteLine(str.Substring(0,5));
            WriteLine(str.Substring(5));

            string[] arr = str.Split(" ");
            WriteLine(arr.Length);

            foreach (string s in arr)
                WriteLine("{0}", s);

        }
    }
}
