using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nawiasy
{
    class Program
    {

        public static bool CheckBrackets(string input)
        {
            Stack<char> brackets = new Stack<char>();
            Dictionary<char, char> bracketPair = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'},
                {'<', '>'},
            };

            try
            {
                foreach (var mark in input)
                {
                    if (bracketPair.Keys.Contains(mark))
                    {
                        brackets.Push(mark);
                    }
                    else if (bracketPair.Values.Contains(mark))
                    {
                        if (mark == bracketPair[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return brackets.Count() == 0 ? true : false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj znaki");
            string input = Console.ReadLine();
            Console.WriteLine(CheckBrackets(input));
        }
    }
}
