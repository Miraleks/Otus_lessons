using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.IfElse
{
	public static class SwitchDemo
	{
		enum Color
		{
			Red,
			Green,
			Blue,
			Yellow,
		}

		static void PrintColors()
		{
			Console.WriteLine(@"
1 - Red,
2 - Green, 
3 - Blue,
4 - Yellow
");
		}

		/// <summary>
		/// Вывод 
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		static string PrintColor(Color color)
		{

			switch (color)
			{
				case Color.Green:
					return "2. Зеленый";
				case Color.Blue:
					return ("2. Синий");
				case Color.Red:
					return ("2. Красный");
				case Color.Yellow:
					return ("2. Желтый");
				default:
					return ("2. Другой цвет");
			}
		}


		/// <summary>
		/// Проверка длины строки
		/// </summary>
		static void CheckLength1()
		{
			string s;
			while ((s = Console.ReadLine()) != string.Empty)
			{
				switch (s.Length)
				{
					case > 15:
						Console.WriteLine("Очень длинная строка");
						break;
					case > 10:
						Console.WriteLine("Длинная строка");
						break;
					case <= 10:
						Console.WriteLine("Короткая строка");
						break;
				}
			}
		}

		static void CheckAge1()
		{
			string s;
			while ((s = Console.ReadLine()) != string.Empty)
			{
				string res;
				var year = int.Parse(s);
				switch (year)
				{
					case > 2000:
						res = "Наш век";
						break;
					case int n when n > 1900 && n < 2000:
						res = "20 век";
						break;
					default:
						res = "Раньше 20 века";
						break;
				}
				Console.WriteLine(res);
			}
		}


		/// <summary>
		/// Проверка года
		/// </summary>
		static void CheckAge2()
		{
			string s;
			while ((s = Console.ReadLine()) != string.Empty)
			{
				var year = int.Parse(s);
				string res = Age1(year);
				Console.WriteLine("age1 " + res);

				res = Age2(year);
				Console.WriteLine("age2 " + res);
			}
		}

		/// <summary>
		/// Какой век 1
		/// </summary>
		/// <param name="year">год</param>
		/// <returns></returns>
		static string Age1(int year)
		{
			return year switch
			{
				> 2000 => "Наш век",
				int n when n > 1900 && n < 2000 => "20 век",
				_ => "Раньше 20 века",
			};
		}

		/// <summary>
		/// Какой век 2
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		static string Age2(int year)
		{
			switch (year)
			{
				case > 2000:
					return "Наш век";
				case int n when n > 1900 && n < 2000:
					return "20 век";
				default:
					return "Раньше 20 века";
			};
		}


		public static void Demo()
		{
			CheckLength1();
			CheckAge1();
			CheckAge2();
		}
	}
}
