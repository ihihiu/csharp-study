using  static System.Console;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 30;

            WriteLine($"{name,-10},{age:D3}");
            WriteLine($"{name},{age,-10:D3}");
            WriteLine($"{name},{(age > 20 ? "adult" : "under age")}");
        }
    }
}
