using static System.Console;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }
    class Derived : Base
    {
        public sealed override void SealMe() //virtual로 선언된 가상 메소드를 오버라이딩한 버전의 메소드이므로 봉인 가능
        {
    
        }
    }
    class WantToOverride : Derived
    {
        public override void SealMe() //재정의 불가능
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
  
        }
    }



}