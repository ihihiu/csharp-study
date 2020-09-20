using  static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Good Morning";

            WriteLine(str);
            WriteLine(str.IndexOf("Good"));
            WriteLine(str.IndexOf('o'));
            WriteLine(str.LastIndexOf("Good"));
            WriteLine(str.LastIndexOf('o'));

            WriteLine(str.StartsWith("Good"));
            WriteLine(str.StartsWith("Morning"));
            WriteLine(str.EndsWith("Good"));
            WriteLine(str.EndsWith("Morning"));

            WriteLine(str.Contains("Good"));
            WriteLine(str.Contains("Bad"));

            WriteLine("{0}", str.Replace("Good", "Bad"));
        }
    }
}
