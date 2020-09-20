using  static System.Console;

namespace StringFormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0:D}", 123);
            WriteLine("{0:D5}", 123);

            WriteLine("0x{0:X}", 0xFF1234);
            WriteLine("0x{0:X8}", 0xFF1234);

            WriteLine("{0:N}", 123456789);
            WriteLine("{0:N0}", 123456789);

            WriteLine("{0:F}", 123456.789);
            WriteLine("{0:F5}", 123456.789);

            WriteLine("{0:E}", 123456.789);

        }
    }
}
