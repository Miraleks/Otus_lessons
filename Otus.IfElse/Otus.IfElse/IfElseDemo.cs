using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.IfElse
{
	public static class IfElseDemo
	{

		static void OddCheck()
		{
			while (true)
			{
				Console.WriteLine("Введите целое число: ");

				var line = Console.ReadLine();

				var number = int.Parse(line);


				if (number % 2 == 0)
				{
					Console.WriteLine($"Вы ввели четное число ({number})");
				}
				else if (number % 4 == 0)
				{
					Console.WriteLine($"Вы ввели нечетное число, и оно делится на 3 - {number}");
				}
				else
				{
					Console.WriteLine($"Вы ввели нечетное число - {number}");
				}
			}
		}

		public static void Demo()
		{
			while (true)
			{
				Console.WriteLine("Введите число");

				var i = int.Parse(Console.ReadLine());

				var otvet = i % 2 == 0
					? "Четное"
					: i % 3 == 0 ? "Нечетное 3" : "Просто нечетное";

				Console.WriteLine(otvet);

			}

			OddCheck();

		}
	}
}
