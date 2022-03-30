using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ZadaniaNaStringach
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Kamil Irzenski";
            string s2 = "Systemy komputerowe i matematyczne";
            string s3 = "Kamil";
            string s4 = "kajak";
            string s5 = "aNnA IrzEnska";
            string s6 = "sTEFan Kowalski";
            string s7 = "D:/Program Files (x86)/Hewlett-Packard/HP Support Framework/temp/plik.txt";
            string s8 = "D:/Program Files (x86)/Hewlett-Packard/HP Support Framework/temp/plik1.2.3.txt";
            string s9 = "D:/Program Files (x86)/Hewlett-Packard/HP Support Framework/temp";
            string s10 = " ";
            string s11 = "    aa    b  c   d     ";


            Console.WriteLine("Hello World!");
            Console.WriteLine($"Funkcja replace {replace("Komputer", 'o', '0')}");
            Console.WriteLine($"Funkcja IndexOf {indexOf("Komputer", 'u')}");
            Console.WriteLine($"Funkcja czy wiecej samoglosek {moreVowels("AAAAAAAAt")}");
            Console.WriteLine($"Funkcja czy wiecej samoglosek {moreVowels("tttttttta")}");
            Console.WriteLine($"Akronim {acronym(s1)}");
            Console.WriteLine($"Akronim {acronym(s2)}");
            Console.WriteLine($"Odwrocony text {reverseText(s3)}");
            Console.WriteLine($"Palindrom 1 {palindrom(s3)}");
            Console.WriteLine($"Palindrom 1 {palindrom(s4)}");
            Console.WriteLine($"Palindrom 2 {palindrom2(s3)}");
            Console.WriteLine($"Palindrom 2 {palindrom2(s4)}");
            Console.WriteLine($"Palindrom 2 {palindrom3(s3)}");
            Console.WriteLine($"Palindrom 2 {palindrom3(s4)}");
            Console.WriteLine($"Powtarzajacy sie znak {ifRepeatChar(s3)}");
            Console.WriteLine($"Powtarzajacy sie znak {ifRepeatChar(s4)}");
            Console.WriteLine($"Powtarzajacy sie znak {ifRepeatChar(s2)}");
            Console.WriteLine($"Poprawione Imie i nazwisko {fixName(s5)}");
            Console.WriteLine($"Poprawione Imie i nazwisko {fixName(s6)}");
            Console.WriteLine($"Nazwy plikow {nameFile(s7)}");
            Console.WriteLine($"Nazwy plikow {nameFile(s8)}");
            Console.WriteLine($"Nazwa plikow {nameFile(s9)}");
            Console.WriteLine($"Nazwa plokow {nameFile(s10)}");
            Console.WriteLine($"Formatowanie tekstu:{doFormatingText(s11)}");
            dotextFormatingToBinary(s3);
            ReverseString(s2);
            CountOccurrenc(s2);
        }

        static string replace(string text, char changeChar, char newChar)
        {
            char[] tabChars = text.ToCharArray();
            for (int i = 0; i < tabChars.Length; i++)
            {
                if (tabChars[i] == changeChar)
                {
                    tabChars[i] = newChar;
                }
            }
            return new string(tabChars);
        }

        static int indexOf(string text, char lookingChar)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == lookingChar)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool moreVowels(string text)
        {
            text = text.ToLower();
            string vowels = "aeiouy";
            int numberVowels = 0;
            int numberConsonat = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char actualyChar = text[i];
                if (char.IsLetter(actualyChar))
                {
                    if (vowels.Contains(actualyChar))
                    {
                        numberVowels++;
                    }
                    else
                    {
                        numberConsonat++;
                    }
                }
            }

            return numberVowels > numberConsonat;
        }

        static string acronym(string text)
        {
            string[] words = text.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                string actualyWords = words[i];
                if (actualyWords.Length == 1)
                {
                    result += char.ToLower(actualyWords[0]);
                }
                else if (actualyWords.Length > 0)
                {
                    result += char.ToUpper(actualyWords[0]);
                }
            }
            return result;
        }

        static string reverseText(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }

        static bool palindrom(string text)
        {
            string textPalindrom = reverseText(text);
            return textPalindrom.Equals(text);
        }

        static bool palindrom2(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = text.Length - 1; j >= 0; j--)
                {
                    if (text[i] == text[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool palindrom4(string text)
        {
            int i = 0;
            int j = text.Length - 1;

            while (i < j)
            {
                if (text[i] != text[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

        static bool palindrom5(string text)
        {
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                if (text[i] != text[j])
                    return false;
            }

            return true;
        }



        static bool palindrom3(string text)
        {
            int indexMiddle = text.Length / 2;
            int i = 0;
            while (i < indexMiddle)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }

                i++;
            }
            return true;
        }

        static bool ifRepeatChar(string text)
        {
            string presentChar = "";
            for (int i = 0; i < text.Length; i++)
            {
                char actualChar = text[i];
                if (presentChar.Contains(actualChar))
                {
                    return true;
                }
                else
                {
                    presentChar += actualChar;
                }
            }

            return false;
        }

        static string fixName(string text)
        {
            string[] splitchar = text.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < splitchar.Length; i++)
            {
                string actualString = splitchar[i].ToLower();
                char[] tabChars = actualString.ToCharArray();
                tabChars[0] = char.ToUpper(tabChars[0]);
                sb.Append(new string(tabChars));
                sb.Append(' ');
            }

            return sb.ToString();
        }

        static string nameFile(string text)
        {
            string[] stringSplit = text.Split("/");
            string lastParts = stringSplit[stringSplit.Length - 1];
            int indexDot = lastParts.LastIndexOf(".");
            if (indexDot != -1)
            {
                return lastParts.Remove(indexDot);
            }
            return "";
        }

        static string doFormatingText(string text)
        {
            string textTrim = text.Trim();  //fukcja trim usuwa spacje z poczatku i konca tekstu
            StringBuilder sb = new StringBuilder();
            char lastchar = ' ';
            for (int i = 0; i < textTrim.Length; i++)
            {
                char actualChar = textTrim[i];
                if (!(actualChar == lastchar && actualChar == ' '))
                {
                    sb.Append(actualChar);
                }

                lastchar = actualChar;
            }

            return sb.ToString();
        }

        static void dotextFormatingToBinary(string text)
        {
            char[] tabChars = text.ToCharArray();
            for (int i = 0; i < tabChars.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                char actualChar = tabChars[i];
                sb.Append(actualChar);
                sb.Append(": ");
                sb.Append((int)actualChar);
                sb.Append(',');
                sb.Append(Convert.ToString((int)actualChar, 2));
                Console.WriteLine(sb.ToString());
            }
        }

        static void ReverseString(string text)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            string[] textSplit = text.Split(" ");
            for (int i = textSplit.Length - 1; i >= 0; i--)
            {
                sb.Append(textSplit[i]);
                sb.Append(' ');
                
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        static void CountOccurrenc(string text)
        {
            string textLower = text.ToLower();
            char actualyChar = ' ';
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < textLower.Length; i++)
            {
                if (false == result.Keys.Any(x =>x == textLower[i]))
                {
                    int count = textLower.Count(x => x == textLower[i]);
                    result.Add(textLower[i], count);
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");   
            }
        }
    }
}
