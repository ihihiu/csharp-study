using static System.Console;

namespace Overriding
{
    class ArmorSuite 
    {
        public virtual void Initialize()
        {
            WriteLine("Armored");
        }   
    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Repulsor Rays Armed");
        }
        public void Print()
        {           
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Double-Barrel Cannons Armed");
            WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize(); //IronMan Initialize
            //ironman.Print(); //부모 클래스의 참조형 변수를 사용했기 때문에 컴파일러는 부모 클래스 객체로 취급
                               //그러므로 오버라이딩이 아닌 IronMan에만 있는 Print()메소드는 사용 못함
            WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }



}