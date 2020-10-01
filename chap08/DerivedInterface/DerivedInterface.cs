using System;
using static System.Console;

namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger //ILogger 상속 받음
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger //IFormattableLogger 상속 받음 
    {
        //ILogger와 IFormatableLogge에 선언된 모든 메소드를 물려 받음
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The World is not flat");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}