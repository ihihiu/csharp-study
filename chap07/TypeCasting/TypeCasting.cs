using static System.Console;

namespace TypeCasting
{
    class Mammal 
    {
        public string name;
        public Mammal() 
        {
            WriteLine("Mammal void constructor");
        }
        public Mammal(string name)
        {
            this.name = name;
            WriteLine("Mammal string constructor");
        }
        public void Nurse()
        {
            WriteLine("Nurse");
        }
    }
    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
            WriteLine("Dog string constructor");
        }
        public void Bark()
        {
            WriteLine("Bark");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            WriteLine("Meow");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            //Mammal mammal = new Mammal();
            //mammal.Nurse();

            //Dog dog = new Dog("happy");
            //dog.Bark();
            //dog.Nurse();
            //dog.name = "puppy";

            Mammal m = new Dog("happy");
            
            Dog d;

            if(m is Dog)
            {
                d = (Dog)m;
                d.Bark();
            }

            m = new Cat();
            Cat c;
            c = m as Cat; // m이 cat이 아니면 null
            if (c != null)
                c.Meow();
        }
    }



}