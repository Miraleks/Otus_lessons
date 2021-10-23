using System;

namespace Practice_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nissan = new Car("Nissan");
            var c = Colors.Blue | Colors.Black | Colors.White;
            Console.WriteLine(c.ToString("F"));

        }


        public enum Colors
        {
            None = 0,
            Red = 1,
            Green = 2,
            Blue = 4,
            Black = 8,
            White = 16
        }


    }
    
}
