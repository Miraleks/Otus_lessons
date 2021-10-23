using System;
using System.Collections.Generic;

namespace HomeWork_04
{
    class Program
    {
        static Dictionary<string, string> data = new();

        static void Main(string[] args)
        {
            bool run = true;

            Menu.Start();

            //Console.WriteLine("a * x^2 + b * x + c = 0");
            do
            {
                try
                {
                    data = InputFunc();
                    SquareRoot(data);
                    run = false;
                }
                catch (ZeroFirstVarException e)
                {
                    FormatData(e.Message, Severity.Warning, data);
                }
                catch (InputFormatException e)
                {
                    FormatData(e.Message, Severity.Error, data);
                }
                catch (NoRootsException e)
                {
                    run = false;
                    FormatData(e.Message, Severity.Warning, null);
                }
            } while (run);
            Console.ReadLine();

        }

        private static Dictionary<string, string> InputFunc()
        {
            Dictionary<string, string> startData = new();
            String readA = "";

            Console.WriteLine("Введите значение a:");
            readA = Console.ReadLine();
            startData.Add("a", readA);
            Console.WriteLine("Введите значение b:");
            String readB = Console.ReadLine();
            startData.Add("b", readB);
            Console.WriteLine("Введите значение c:");
            String readC = Console.ReadLine();
            startData.Add("c", readC);

            startData = ValueParse(readA, readB, readC, startData);

            return startData;

        }

        private static Dictionary<string, string> ValueParse(string readA, string readB, string readC, Dictionary<string, string> data)
        {
            Dictionary<string, string> correctData = new();
            
            if (int.TryParse(readA, out var a))
            {
                if (int.Parse(readA) == 0)
                {
                    Program.data.Clear();
                    Program.data.Add("a", "0");
                    //FormatData("Коэффициент а равен нулю.", Severity.Warning, wrongData);
                    throw new ZeroFirstVarException("Коэффициент а равен нулю.");
                }
                data.Remove("a");
                correctData.Add("a", readA);
            }
            
            if (int.TryParse(readB, out var b))
            {
                data.Remove("b");
                correctData.Add("b", readB);
            }
            
            if (int.TryParse(readA, out var c))
            {
                data.Remove("c");
                correctData.Add("c", readC);
            }

            if (data.Count != 0)
            {
                Program.data = data;
                throw new InputFormatException ("Введены некорректные данные для следующих значений");
            }

            return correctData;
        }

        private static void SquareRoot(Dictionary<string, string> data) 
        {

            int a = int.Parse(data["a"]);
            int b = int.Parse(data["b"]);
            int c = int.Parse(data["c"]);
            double x1, x2;
            //дискриминант
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                throw new NoRootsException("Вещественных значений не найдено");               
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);                  
                    Console.WriteLine($"x1 = x2 = {x1}");

                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
                }

                //вывод корней уравнения

            }
        }
        public static void FormatData(string message, Severity severity, Dictionary<string, string> data) 
        {
            string line = "";
            string freeSpace = "";
            string freeSpaceMessage = "";
            for (int i = 0; i < 50 - message.Length; i++)
            {
                freeSpaceMessage += " ";
            }
            for (int i = 0; i < 50; i++)
            {
                line += "-";
            }

            switch (severity)
            {
                case Severity.Warning:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(line);
                    Console.WriteLine(message+freeSpaceMessage);
                    Console.WriteLine(line);                  
                    break;
                case Severity.Error:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(line);
                    Console.WriteLine(message+freeSpaceMessage);
                    Console.WriteLine(line);
                    break;
            }
            if (data != null)
            {
                foreach (KeyValuePair<string, string> item in data)
                {
                    for (int i = 0; i < 50 - item.Key.Length - item.Value.Length - 3; i++)
                    {
                        freeSpace += " ";
                    }
                    Console.WriteLine($"{item.Key} = {item.Value}{freeSpace}");
                    freeSpace = "";
                }
            }
            Console.WriteLine(line);
            Console.ResetColor();
        }

        public enum Severity 
        { 
            Warning, 
            Error, 
        }
    }

    [Serializable]
    internal class InputFormatException : Exception
    {
        public InputFormatException(string message) : base(message)
        {
        }
    }

    [Serializable]
    internal class NoRootsException : Exception
    {
        public NoRootsException(string message) : base(message)
        {
        }
    }

    [Serializable]
    internal class ZeroFirstVarException : Exception
    {
        public ZeroFirstVarException(string message) : base(message)
        {
        }
    }

}
