using static System.Console;

namespace This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string getName()
        {
            return Name;
        }
        public void setPosition(string Position)
        {
            this.Position = Position;
        }
        public string getPosition()
        {
            return Position;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.setName("Pooh");
            pooh.setPosition("Waiter");
            WriteLine($"{pooh.getName()}, {pooh.getPosition()}");

            Employee tigger = new Employee();
            tigger.setName("Tigger");
            tigger.setPosition("Cleaner");
            WriteLine($"{tigger.getName()}, {tigger.getPosition()}");
        }
    }
}
