using System;
using System.Threading.Channels;

namespace Zadanie2
{
    class ZadaniaNatablicach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablice Wielowymiarowe");
            int[,] tab1 = { { 1, 2, 3, 4 }, { 2, 5, 2, 7 }, { 6, 2, 2, 7 } };
            int[,] tab2 = { { 2, 5, 8, 2 }, { 6, 2, 8, 2 }, { 3, 5, 7, 2 } };
            int[][] tab3 = new int[3][];
            tab3[0] = new int[2] { 2, 1 };
            tab3[1] = new int[5] { 3, 6, 8, 9, 7 };
            tab3[2] = new int[4] { 2, 9, 7, 3 };
            int[] tab4 = { 4, 5, 5, 5, 2, 1, 6 };
            int[] tab5 = { 2, 3, 6, 1, 3, 0, 7 };
            int[] tab6 = { };
            test(tab1);
            test(tab2);
            test2(tab3);
            test3(tab4);
            test3(tab5);
            test3(tab6);
        }

        static void test2(int[][] tab)
        {
            displayTab(tab);
            Console.WriteLine($"Wartosc minum: {min(tab, 0)}");
            Console.WriteLine($"Wartosc maximum: {max(tab, 0)}");
            displayTab(arrayOfArraysToArray(tab, 0));
            Console.WriteLine("_________________");
        }

        static void test(int[,] tab)
        {
            displayTab(tab);
            Console.WriteLine($"Suma elementow: {sumElement(tab)}");
            Console.WriteLine($"Suma przekontnych: {sumElementDiagonal(tab)}");
            Console.Write("Ilosc szukanej w kolumnach: ");
            displayTab(quantityInColumns(tab, 2));
            Console.WriteLine();
            Console.WriteLine("Tablica tablic");
            displayTab(arrayToArrayofArrays(tab));
            Console.WriteLine();
            Console.WriteLine("__________________");
        }

        static void test3(int[] tab)
        {
            int minium = 0;
            displayTab(tab);
            Console.WriteLine();
            Console.WriteLine($"Suma elementow tablicy jednowymiarowej: {sumElement(tab)}");
            //if (min(tab, out minium))
            //{
            //    Console.WriteLine($"Wartosc minum {minium}");
            //}
            //else
            //{
            //    Console.WriteLine("zly parametr wejsciowy");
            //}

            Console.WriteLine($"Wartosc maximum {max(tab)}");
            Console.WriteLine();
            Console.WriteLine($"Dominanta {dominant(tab)}");
            Console.WriteLine($"Ile wystapien danej liczby: {howManyAppear(tab, 3)}");
            Console.WriteLine("___________________");
            Console.WriteLine($"Tablica palindrom: {ArrayPalindrom(tab)}");
        }

        static void displayTab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j]);
                    Console.Write(", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static int dominant(int[] tab)
        {
            int minimum = min(tab);
            int maximum = max(tab);
            int[] helperTab = new int[maximum - minimum + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                helperTab[tab[i] - minimum]++;
            }
            int appearValue = max(helperTab);
            int result = 0;
            for (int i = 0; i < helperTab.Length; i++)
            {
                if (helperTab[i] == appearValue)
                {
                    result = i + minimum;
                }
            }
            return result;
        }

        static int howManyAppear(int[] tab, int value)
        {
            int howMany = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == value)
                {
                    howMany++;
                }
            }

            return howMany;

        }

        static int sumElement(int[,] tab)
        {
            int sum = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    sum += tab[i, j];
                }
            }

            return sum;
        }

        static int sumElement(int[] tab)
        {
            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum += tab[i];
            }
            return sum;
        }


        static int sumElementDiagonal(int[,] tab)
        {
            int sum = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += tab[i, j];
                    }
                }
            }

            return sum;
        }

        static void displayTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
                Console.Write(", ");
            }
        }

        static int[] quantityInColumns(int[,] tab, int szukana)
        {
            int[] resultTab = new int[tab.GetLength(1)];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == szukana)
                    {
                        resultTab[j]++;
                    }
                }
            }

            return resultTab;
        }

        static void displayTab(int[][] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
        }

        static int min(int[][] tab, int numberRow)
        {
            if (numberRow > tab.Length)
            {
                return 0;
            }

            if (numberRow < 0)
            {
                return 0;
            }

            return min(tab[numberRow]);
        }

        static int max(int[][] tab, int numberPoem)
        {
            if (numberPoem > tab.Length)
            {
                return 0;
            }

            if (numberPoem < 0)
            {
                return 0;
            }

            return max(tab[numberPoem]);
        }

        static int min(int[] tab)
        {

            if (tab.Length == 0)
            {
                return 0;
                //throw new Exception("empty array");
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

        //static int? min(int[] tab)
        //{
        //    if (tab == null)
        //    {
        //        return null;
        //    }

        //    if (tab.Length == 0)
        //    {
        //        return null;
        //        //throw new Exception("empty array");
        //    }

        //    int? minimum = tab[0];
        //    for (int i = 0; i < tab.Length; i++)
        //    {
        //        if (tab[i] < minimum)
        //        {
        //            minimum = tab[i];
        //        }
        //    }

        //    return minimum;
        //}

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

        static int[,] arrayOfArraysToArray(int[][] tab, int defaultValue = 0)
        {
            int[] lenghtLines = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                lenghtLines[i] = tab[i].Length;
            }

            int maxLenghtPoem = max(lenghtLines);
            int[,] tabResault = new int[tab.Length, maxLenghtPoem];
            for (int i = 0; i < tabResault.GetLength(0); i++)
            {
                for (int j = 0; j < tabResault.GetLength(1); j++)
                {
                    if (j < tab[i].Length)
                    {
                        tabResault[i, j] = tab[i][j];
                    }
                    else
                    {
                        tabResault[i, j] = defaultValue;
                    }
                }
            }

            return tabResault;
        }

        static int[][] arrayToArrayofArrays(int[,] tab)
        {
            int[][] tabResault = new int[tab.GetLength(0)][];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tabResault[i] = new int[tab.GetLength(1)];

                for (int j = 0; j < tab.GetLength(1); j++)

                    tabResault[i][j] = tab[i, j];
            }

            return tabResault;
        }

        static bool ArrayPalindrom(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = tab.Length; j >= 0; j--)
                {
                    if (tab[i] == tab[j])
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

        
    }
}
