using System;
using System.Collections;
using static System.Console;

namespace DelegateChains
{
    class Program
    {
        delegate void ThereIsAFire(string location);
        static void Call119(string location)
        {
            WriteLine("소방서죠? 불났어요! 주소는 {0}", location);
        }
        static void Shoutout(string location)
        {
            WriteLine("피하세요! {0}에 불이 났어요!", location);
        }
        static void Escape(string location)
        {
            WriteLine("{0}에서 나갑시다!", location);
        }
        static void Main(string[] args)
        {
            ThereIsAFire Fire = new ThereIsAFire(Call119); //대리자 호출, Call119() 메소드를 매개 변수로
            Fire += new ThereIsAFire(Shoutout);
            Fire += new ThereIsAFire(Escape);

            //Fire = (ThereIsAFire)Delegate.Combine(new ThereIsAFire(Call119),new ThereIsAFire(Shoutout))
            
            Fire("우리집");
        }

    }
}