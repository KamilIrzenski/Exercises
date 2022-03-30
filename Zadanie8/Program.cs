using System;

namespace Zadanie8
{

    abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

    }

    class Man : Person
    {
        public Man(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public void SayHi()
        {
            Console.WriteLine($"Na imie mam {Name} {LastName}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Man kamil = new Man("Kamil", "Irzeński");

            //kamil.Name = "Kamil";


            kamil.SayHi();
        }
    }
}
