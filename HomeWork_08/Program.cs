using System;
using System.Diagnostics;
using System.Threading;

namespace HomeWork_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch totalTime = new();
            totalTime.Start();
            FibonacciWithRecursion(5);
            FibonacciWithRecursion(15);
            FibonacciWithRecursion(20);
            FibonacciWithRecursion(30);
            FibonacciWithRecursion(50);

            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine();

            FibonacciWithIteration(5);
            FibonacciWithIteration(15);
            FibonacciWithIteration(20);
            FibonacciWithIteration(30);
            FibonacciWithIteration(150);
            Console.WriteLine();
            Console.WriteLine("*****************");

            totalTime.Stop();
            TimeSpan timeTotal = TimeSpan.FromTicks(totalTime.ElapsedTicks);

            Console.WriteLine($"Total time for caclulation: {timeTotal.ToString()}");
        }

        static void FibonacciWithRecursion(ulong a)
        {
            Stopwatch timer = new();

            timer.Start();

            Console.WriteLine("Fibonacci With Recursion Start");
            if (a == 2)
            {
                Console.WriteLine("Second element Fibonacci: 1");
            }
            else if (a == 1)
            {
                Console.WriteLine("First element Fibonacci: 0");
            }
            else
            {
                ulong number = FibonacciNumberCalculate(a - 1);
                Console.WriteLine($"Element in {a} place is: {number}");
                Console.WriteLine("Fibonacci With Recursion Stop");
            }
            timer.Stop();

            TimeSpan timeTotalTicks = TimeSpan.FromTicks(timer.ElapsedTicks);
            Console.WriteLine($"Time for calculate: {timeTotalTicks.ToString()}");

            //Console.WriteLine($"Ticks for calculate: {timer.ElapsedTicks}");
        }
        static void FibonacciWithIteration(ulong a)
        {
            Stopwatch timer = new();
            Console.WriteLine("Fibonacci With Iteration Start");
            timer.Start();

            ulong firstNumber = 0, SecondNumber = 1, nextNumber = 0;

            for (ulong i = 2; i < a; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }


            //long ts = timer.ElapsedMilliseconds;
            Console.WriteLine($"Element in {a} place is: {nextNumber}");

            timer.Stop();
            TimeSpan timeTotalTicks = TimeSpan.FromTicks(timer.ElapsedTicks);
            Console.WriteLine($"Time for calculate: {timeTotalTicks.ToString()}");

            Console.WriteLine("Fibonacci With Iteration Stop");


        }

        static ulong FibonacciNumberCalculate(ulong a)
        {
            if (a <= 2)
                return 1;
            else
                return FibonacciNumberCalculate(a - 1) + FibonacciNumberCalculate(a - 2);
        }
    }
}