using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class Person
    {
        public string Firstname;
        public string LastName;
        public static string SecondName;
        private string contactNumber;
        public static int Count = 0;

        public DateTime DateOfBirth { get; set; }

        public Person(string firstname, string lastName)
        {
            LastName = lastName;
            Firstname = lastName;
            Count++;
        }
        public Person(string firstname, string lastName, DateTime dateOfBirth) : this(firstname, lastName)
        {
            DateOfBirth = dateOfBirth;
        }



        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Numer nie prawidłowy");
                }
                else
                {
                    contactNumber = value;
                }
              
            }
        }

        
        //public DateTime DateOfBirth
        //{
        //    get { return dateOfBirth; }
        //    set { dateOfBirth = value; }
        //}
        //public void SetDateOfBirth(DateTime date)
        //{
        //    if (date > DateTime.Now)
        //    {
        //        Console.WriteLine("Nieprawidłowa data");
        //    }
        //    else
        //    {
        //        dateOfBirth = date;
        //    }
        //}
        //public DateTime GetDateofBirth() => dateOfBirth;


        public void SayHi()
        {
            Console.WriteLine($"Czesc mam na imie {Firstname} {LastName} i urodzilem sie {DateOfBirth} a to moj numer tel {contactNumber}");
        }

    }


}
