using System;
using System.IO;
using static System.Console;

namespace Interface
{
   interface ILogger //접근 한정자를 사용할 수 없음 (모두 public으로 선언됨)
    {
        void WriteLog(string message); //인터페이스에 선언된 메소드는 파생 클래스에서 반드시 구현
    }
    class ConsoleLogger : ILogger //ILogger 인터페이스를 상속 받는 파생 클래스
    {
        public void WriteLog(string message) //인터페이스로부터 상속받은 WriteLog() 메소드 구현 
        {
            WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class FileLogger : ILogger //ILogger 인터페이스를 상속 받는 파생 클래스
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message) //인터페이스로부터 상속받은 WriteLog() 메소드 구현 
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }
    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger) 
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Write("온도를 입력해주세요. : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
        }
    }
}
