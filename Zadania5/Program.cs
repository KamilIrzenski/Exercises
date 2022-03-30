using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

namespace Zadania5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabInts = { 2, 5, 5, 5, 6, 9, 2, 1, };
            string s1 = "Kamil";
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Silnia {silnia(6)}");
            Console.WriteLine($"Silnia {silnia2(6)}");
            Console.WriteLine($"Wartość bezwgledna {absoluteValue(-5)}");
            Console.WriteLine($"Wartość bezwgledna {absoluteValue(9)}");
            Console.WriteLine($"Suma wartosci w tablicy {sumValueInTab(tabInts)}");
            Console.WriteLine($"Zliczenie wystapien danej cyfry {sumAppearInTab(tabInts, 5)}");
            Console.WriteLine($"Maksymalna wartosc {max(tabInts)}");
            Console.WriteLine($"Maksymalna wartosc {min(tabInts)}");
            Console.WriteLine($"Odwrocony tekst {OdwroconyString(s1)}");
        }

        static int silnia(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * silnia(n - 1);
            }
        }

        static int silnia2(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static int absoluteValue(int value)
        {
            int result = 0;
            if (value >= 0)
            {
                return value;
            }
            else
            {
                result -= value;
            }

            return result;
        }

        static int sumValueInTab(int[] tab)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i];
            }

            return result;
        }

        static int sumAppearInTab(int[] tab, int checkValue)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == checkValue)
                {
                    result += 1;
                }
            }

            return result;
        }

        static int max(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int maximum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > maximum)
                {
                    maximum = tab[i];
                }
            }

            return maximum;
        }

        static int min(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }

            int minimum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < minimum)
                {
                    minimum = tab[i];
                }
            }

            return minimum;
        }

        static int Silnia3(int value)
        {
            int result = 0;
            for (int i = 0; i <= value; i++)
            {
                result = result * i;
            }

            return result;
        }

        static int SilniaReku(int value)
        {
            if (value < 1)
            {
                return 1;
            }
            else
            {
                return value * SilniaReku(value - 1);
            }
        }

        static int MaxymanlnaWartosc(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }

            int maximum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > maximum)
                {
                    maximum = tab[i];
                }
            }

            return maximum;
        }

        static int MinimalnaWartosc(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }

            int minimum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < minimum)
                {
                    return minimum;
                }
            }

            return minimum;
        }
        static int SumaWartosci2(int[] tab)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i];
            }
            return result;
        }

        static bool Palindrom5(string text)
        {
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                if (i != j)
                {
                    return false;
                }
            }
            return true;
        }

        static string OdwroconyString(string text)
        {
            string result = "";
            for (int i = text.Length -1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }

    }
}
