using System;

namespace Algorytmy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            algoritm1();
            algorytm2();
            algorytm3();
            Console.Read();
        }

        static int getValue()
        {
            Console.WriteLine("Podaj liczbe:");
            return int.Parse(Console.ReadLine());
        }

        static void algoritm1()
        {
            int value = getValue();
            if (checkEven(value))
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nie parzysta");
            }
        }

        static bool checkEven(int value)
        {
            return value % 2 == 0;
        }

        static int absoluteValue(int value)
        {
            if (value < 0)
            {
                return -value;
            }

            return value;
        }

        static void algorytm2()
        {
            Console.WriteLine(absoluteValue(getValue()));
        }

        static void algorytm3()
        {
            Console.WriteLine("Podaj cyfry");
            Console.WriteLine(sumDigits(getValue()));
        }

        static int sumDigits(int value)
        {
            int sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }

            return sum;
        }


    }
}
