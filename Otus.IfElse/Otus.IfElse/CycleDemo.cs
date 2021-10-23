using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.IfElse
{
	static class CycleDemo
	{


		/// <summary>
		/// Обычный цикл
		/// </summary>
		static void Cycle()
		{
			var list = new int[] { 1, 2, 3, 4 };

			for (

				int i = 0, j = 0;

				i < list.Length || j < 10;


				i++, j += 10)
			{
				var item = list[i];
				Console.WriteLine($"[{j}] {item}");
			}

		}


		/// <summary>
		/// Демо foreach
		/// </summary>
		static void ForeachDemo()
		{
			var ar = new[] { 1, 2, 3, 4, 5, 6, 7 };
			foreach (var i in ar)
			{
				Console.WriteLine(i);
			}

			for (var r = 0; r < ar.Length; r++)
			{
				var j = ar[r];
				Console.WriteLine(j);
			}

			var ii = ar.GetEnumerator();

			while (ii.MoveNext())
			{
				Console.WriteLine(ii.Current);
			}




		}


		/// <summary>
		/// Демо break и continue
		/// </summary>
		static void BreakDemo()
		{

			for (var i = 0; i < 20; i++)
			{
				if (i == 13)
				{
					Console.WriteLine("13 - несчастливое число");
					break;
				}

				Console.WriteLine($"{i} * {i} = {i * i}");
			}

			Console.WriteLine("-----------------");

			for (var i = 0; i < 20; i++)
			{
				if (i == 13)
				{
					Console.WriteLine("13 - несчастливое число");
					continue;
				}

				Console.WriteLine($"{i} * {i} = {i * i}");
			}
			Console.WriteLine("Это текст так и не выведется");


		}


		static void InnerBreakDemo()
		{
			for (var j = 10; j < 15; j++)
			{
				for (var i = 10; i < 15; i++)
				{
					if (i == 13)
					{
						Console.WriteLine("13 - несчастливое число");
						break;
					}

					Console.WriteLine($"{j} * {i} = {j * i}");
				}
				Console.WriteLine($"j равно {j}");
			}
			Console.WriteLine("Это текст так и не выведется");

		}


		/// <summary>
		/// Цикл через GOTO
		/// </summary>
		static void GotoCycle()
		{
			var i = 0;

		START:
			if (i < 5)
			{
				Console.WriteLine(i);
				i += 1;
				goto START;
			}
			else
			{
				goto FINISH;
			}

		FINISH:
			Console.WriteLine("Финиш");
		}

		/// <summary>
		/// Демо GOTO
		/// </summary>
		static void GotoDemo()
		{
			for (var i = 0; i < 20; i++)
			{
				if (i == 13)
				{
					goto MARK13;
				}

				Console.WriteLine($"{i} * {i} = {i * i}");
			}


			Console.WriteLine("Это текст так и не выведется");

		MARK13:
			Console.WriteLine("Я оказался здесь из-за goto");
		}

		public static void Demo()
		{
			Cycle();
			GotoCycle();
			InnerBreakDemo();
			BreakDemo();
			ForeachDemo();
		}
	}
}
