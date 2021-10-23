using System;


namespace HomeWork_04
{
    class Menu
    {
        private static string[] options = new[]{
            "a:",
            "b:",
            "c:",
        };

        private static void SetDown()
        {
            if (selectedValue < options.Length - 1)
            {
                selectedValue++;
            }
        }

        private static void SetUp()
        {
            if (selectedValue > 0)
                selectedValue--;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("a * x ^ 2 + b * x + c = 0");
            Console.WriteLine();
            for (var i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{(selectedValue == i ? ">" : " ")} {i + 1}. {options[i]}");
            }
        }

        private static int selectedValue = 0;



        public static void Start()
        {
            ConsoleKeyInfo ki;
            do
            {
                PrintMenu();

                ki = Console.ReadKey();

                switch (ki.Key)
                {
                    case ConsoleKey.UpArrow:
                        SetUp();
                        break;
                    case ConsoleKey.DownArrow:
                        SetDown();
                        break;
                }
                Console.Clear();
            } while (ki.Key != ConsoleKey.Escape);
        }
    }
}
