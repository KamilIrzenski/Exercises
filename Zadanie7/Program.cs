using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "kajak";
            string s2 = "kamil";

            Console.WriteLine($"Palindrom: {Palindrom(s1)}");
            Console.WriteLine($"Palindrom: {Palindrom(s2)}");
            Console.WriteLine($"Suma znakow {SumCharInText(s1)}");
            Console.WriteLine($"Odwrocony text {ReverseText(s2)}");
            Console.WriteLine($"Czy wystepuje {CzyWystepuje(s2,'i')}");
        }

        static bool Palindrom(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = text.Length - 1; j >= 0; j--)
                {
                    if (text[i] == text[j])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static int SumCharInText(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result += text[i];
            }
            return result;
        }

        static string ReverseText(string text)
        {
            string result = "";
            for (int i = text.Length -1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }

        static bool CzyWystepuje(string text, char value)
        {
            char[] tabChars = text.ToCharArray();
            for (int i = 0; i < tabChars.Length; i++)
            {
                if (tabChars[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        static int SilniaZnowu(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * SilniaZnowu(value - 1);
            }
        }
    }
}
