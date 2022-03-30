using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace CodeWarsTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string s1 = "world";
			int[] tab = {1, 2, 3, 4};

			double[] tab2 = {1, 5, 9, 1.5};
			double[] tab3 = {0};
			double[] tab4 = {-2, 398};
			double[] tab5 = { 1, 5.2, 4, 0, -1};


		//Console.WriteLine($"Grow {Maps(tab)}");
		// DisplayTab(Maps2(tab));
		// Console.WriteLine($"min {Min(tab)}");
		Console.WriteLine($"Sum {SumArray(tab2)}");
			Console.WriteLine($"Sum {SumArray(tab3)}");
			Console.WriteLine($"Sum {SumArray(tab4)}");
			//ReverseText2(s1);

			//Console.WriteLine(ReverseText3(s1));
			//Console.WriteLine($"Lovefunc{lovefunc(2,2)}");

		}

		public static int Paperwork(int n, int m)
		{
			if (n < 0 || m < 0)
			{
				return 0;
			}
			else
			{
				int sum = 0;
				sum = m * n;
				return sum;
			}
		}



		public static double SumArray(double[] array)
		{
			if (array == null)
			{
				return 0;
			}
			else
			{
				double sum = 0;

				for (int i = 0; i < array.Length; i++)
				{
					sum += array[i];
				}

				return sum;
			}

		}


		public static int Min(int[] list)
		{
			return list.Min();
		}
		public static void DisplayTab(int[] tab)
		{
			for (int i = 0; i < tab.Length; i++)
			{
				Console.Write(tab[i]);
			}
		}

		public static int[] Maps2(int[] tab)
		{
			return tab.Select(x => x * 2).ToArray();
		}
		public static int[] Maps(int[] tab)
		{
			int[] result = new int[tab.Length];
			for (int i = 0; i < tab.Length; i++)
			{
				result[i] = tab[i] * 2;
			}
			return result;
		}

		public static int Grow(int[] tab)
		{
			int result = 1;
			for (int i = 0; i < tab.Length; i++)
			{
				result *= tab[i];
			}
			return result;
		}

		public static int Grow2(int[] tab)
		{
			return tab.Aggregate((a, b) => a * b);
		}

		static bool lovefunc(int flower1, int flower2)
		{

			if (flower1 %2 == 0 && flower2 % 2 != 0 || flower2 % 2 == 0 && flower1 % 2 != 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}


		static string ReverseText(string text)
		{
			string result = "";
			for (int i = text.Length - 1; i >= 0; i--)
			{
				result += text[i];
			}

			return result;
		}

		static string ReverseText2(string text)
		{
			return new string(text.Reverse().ToArray());
		}

		static string ReverseText3(string text) => string.Concat(text.Reverse());

	}
}
