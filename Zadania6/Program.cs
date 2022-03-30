using System;
using Zadanie6;

namespace Zadania6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person ania = new Person("Kamil", "Irzeński", new DateTime(1991, 02, 25));
            ania.ContactNumber = "999888777";

            // person.Firstname = "Kamil";
            // person.DateOfBirth = new DateTime(1991, 02, 02);
            
            Person kamil = new Person("Kamilllllll", "Irzenskiiiiii");
            kamil.DateOfBirth = new DateTime(1991, 05, 05);
            kamil.ContactNumber = "888831654";
            kamil.SayHi();
            ania.SayHi();

            Console.WriteLine($"Ilosc obiektow {Person.Count}");
        }
    }
}
