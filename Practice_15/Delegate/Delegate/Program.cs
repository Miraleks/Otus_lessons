using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 7;
            double result = Sum(x, y);
            //result = Diff(x, y);

            Calculate(5, 7, Sum);
            Calculate(5, 7, Diff);

            Console.WriteLine("---");
            Console.WriteLine();

            Calculate(5, 7, delegate (double arg1, double arg2)
             {
                 Console.WriteLine("(Анонимный метод считает...)");
                 return arg1 + arg2;
             });

            Calculate(5, 7, (arg1, arg2) =>
            {
                Console.WriteLine("лямбда-выражение считает...");
                return arg1 + arg2;
            });
            Console.WriteLine("---");
            Console.WriteLine();

            Console.WriteLine("Однострочное лямбда-выражение");
            Calculate(5, 7, (arg1, arg2) => arg1 + arg2);
            Console.WriteLine("---");
            Console.WriteLine();

            BiFunc lambda1 = (arg1, arg2) => arg1 + arg2;
            Console.WriteLine("Вызов лямбды, сохраненной в переменную-делегат " + lambda1(5, 7));
            Console.WriteLine("---");
            Console.WriteLine();

            Func<double, double, double> lambda2 = (arg1, arg2) => arg1 + arg2;
            Console.WriteLine("Вызов лямбды, сохраненной в переменную-Func " + lambda1(5, 7));
            Console.WriteLine("---");
            Console.WriteLine();

        }

        static double Diff(double x, double y)
        {
            return x - y;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }

        static void Calculate(double arg1, double arg2, BiFunc processor)
        {
            Console.WriteLine("Вызов делегата: " + processor(arg1, arg2));
        }

        delegate double BiFunc(double arg1, double arg2);
    }
}
