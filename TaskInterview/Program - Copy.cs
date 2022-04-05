//using System;
//using System.Threading.Channels;

//namespace TaskInterview
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {

//            int[,] Sudoku =   { {1, 5, 7, 4, 8, 3, 6, 2, 9 },
//                                {6, 3, 8, 1, 2, 9, 7, 5, 4 },
//                                {4, 9, 2, 5, 6, 7, 1, 3, 8 },
//                                {8, 4, 5, 9, 7, 6, 3, 1, 2 },
//                                {7, 2, 1, 3, 5, 8, 9, 4, 6 },
//                                {3, 6, 9, 2, 1, 4, 5, 8, 7 },
//                                {5, 1, 6, 7, 4, 2, 8, 9, 3 },
//                                {2, 8, 3, 6, 9, 1, 4, 7, 5 },
//                                {9, 7, 4, 8, 3, 5, 2, 6, 1 }};


//            Console.WriteLine("Hello World!");
//            Console.WriteLine($"First Perfect Squear {FirstPerfectSquer(11)}");

//            string[] Symbol = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X",
//                "IX", "V", "IV", "I"};

//            int[] Weight = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

//            //  ConvertToRomanNumeral(Weight, Symbol);

//            Console.WriteLine($"Sudoku row {CheckRows(Sudoku)}");

//            Console.WriteLine($"Sudoku column {CheckColumns(Sudoku)}");
//            Console.WriteLine($"Sudoku subMatrix {CheckSubbMatrix(Sudoku)}");
//        }

//        static int FirstPerfectSquer(double value)
//        {
//            double result = 0;
//            while (true)
//            {
//                result = Math.Sqrt(value);
//                if (result % 1 == 0)
//                {
//                    return (int)value;
//                }
//                else
//                {
//                    value++;
//                }
//            }
//        }

//        static void ConvertToRomanNumeral(int[] tabInts, string[] tabStrings)
//        {
//            Console.Write("Enter an intiger: ");
//            int input = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"Roman figure of the number {input}");
//            int i = 0;
//            while (input > 0)
//            {
//                if (input >= tabInts[i])
//                {
//                    Console.Write(tabStrings[i]);
//                    input -= tabInts[i];
//                }
//                else
//                {
//                    i++;
//                }
//            }
//        }


//        static bool CheckRows(int[,] tab)
//        {
//            int presentInt = 0;
//            for (int row = 0; row < tab.GetLength(1); row++)
//            {
//                Console.WriteLine("");
//                for (int j = 0; j < tab.GetLength(0); j++)
//                {
//                    int actualInt = tab[row, j];
//                    for (int k = j + 1; k < tab.GetLength(0); k++)
//                    {
//                        int testInt = tab[row, k];
//                        if (actualInt == testInt)
//                        {
//                            return false;
//                        }
//                    }
//                }
//            }

//            return true;
//        }
//        static bool CheckColumns(int[,] tab)
//        {
//            int presentInt = 0;
//            for (int column = 0; column < tab.GetLength(0); column++)
//            {
//                Console.WriteLine("");
//                for (int j = 0; j < tab.GetLength(1); j++)
//                {
//                    int actualInt = tab[j, column];
//                    for (int k = j + 1; k < tab.GetLength(1); k++)
//                    {
//                        int testInt = tab[k, column];
//                        if (actualInt == testInt)
//                        {
//                            return false;
//                        }
//                    }
//                }
//            }

//            return true;
//        }

//        static bool CheckSubbMatrix(int[,] tab)
//        {
//            for (int subRow = 0; subRow < tab.GetLength(0); subRow += 3)
//            {
//                for (int subCol = 0; subCol < tab.GetLength(1); subCol += 3)
//                {
//                    int sum = 0;
//                    for (int j = subRow; j < subRow + 3; j++)
//                    {
//                        for (int k = subCol; k < subCol + 3; k++)
//                        {
//                            sum += tab[j, k];
//                        }
//                    }

//                    if (sum != 45)
//                    {
//                        return false;
//                    }
//                }
//            }

//            return true;
//        }
//    }
//}
