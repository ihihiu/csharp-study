using  static System.Console;

namespace StringFormatBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1,-15}{2,30}";
            WriteLine(fmt,"Publisher", "Author", "Title");
            WriteLine(fmt, "aaaaa", "bbbbbb", "ccc");
            WriteLine(fmt, "dddd", "eeeeee", "fffffffffffff");
            WriteLine(fmt, "ggggggggg", "hhhhhh", "iiiiiiiiii");

        }
    }
}
