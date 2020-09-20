using  static System.Console;

namespace StringModify
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Good Morning";

            WriteLine(str);
            WriteLine(str.ToLower());
            WriteLine(str.ToUpper());

            WriteLine(str.Insert(4, " Happy"));
            WriteLine(str.Remove(0, 5));

            WriteLine("   No Spaces   ". Trim());
            WriteLine("   No Spaces   ".TrimStart());
            WriteLine("   No Spaces   ".TrimEnd());

        }
    }
}
