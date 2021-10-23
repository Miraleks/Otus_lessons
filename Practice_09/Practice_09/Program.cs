using System;

namespace Practice_09
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintString("I'm a string. And me printed");
            PrintDate(DateTime.Today);
            PrintDate(2021, 9, 8);

            DateTime.Now.Print();

            PrintYear("01.09.2021");
            PrintYear();

        }

        private static void PrintYear(string v = "2021.01.01")
        {
            var delim = '.';
            var str = v.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            string[] newData = new String[str.Length];
            var count = 0;

            for (int i = str.Length; i > 0; i--)
            {
                newData[count] = str[i-1];
                count++;
            }

            Console.WriteLine($"{newData[0]}.{newData[1]}.{newData[2]}");
        }

        public static void PrintString(string s)
        {
            Console.WriteLine(s);
        }

        public static void PrintDate(DateTime date)
        {

            Console.WriteLine(date.ToShortDateString());
        }

        public static void PrintDate(int year, int month, int day)
        {

            Console.WriteLine($"{day}.{month}.{year}");
        }
    }
    public static class Extensions
    {
        public static void Print(this DateTime day)
        {
            Console.WriteLine(day.ToShortDateString());
        }
    }
}
