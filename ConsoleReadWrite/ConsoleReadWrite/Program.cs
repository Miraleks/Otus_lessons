using System;

namespace ConsoleReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Вывести текст "введите размерность таблицы:"
            после этого считать вводимую строку от пользователя в виде целого числа, 
            если введенная строка не соответствует формату целого числа (не парсится), 
            то нужно повторно вывести текст введите размерность таблицы: , 
            и выводить его до тех пор, пользователь не введет корректное число.
            Число должно быть не меньше 1, и не больше 6. Обозначим его как n.

            Вывести текст "введите произвольный текст:" , 
            если пользователь введет пустой текст, снова выводим введите произвольный текст: ,
            до тех пор, пока пользователь не введет непустую строку.

            Нужно вывести таблицу,
            у которой будут следующие свойства 
            3.1. Ее ширина не должна превышать 40 символов 
            3.2. Границы таблицы - символ + 
            3.3. Ширина таблицы (каждой строки) зависит от числа n и длины введенной строки из п.2. 
            3.4. Вывести 1ю строку таблицы с текстом, введенным в п.2., 
            который находится на расстоянии n-1 от каждой из границ строки. 
            3.5. Вывести 2ю строку таблицы. Она имеет ту же высоту, что и строка 1,
            и представляет собой набор символов +, чередующихся в шахматном порядке. 
            3.6. Вывести 3ю строку таблицы. Она должна быть квадратной, "перечеркнутая" символом + по диагоналям

            Критерии оценки:
            2 балла - за каждую строку (итого 6) 
            1 балл - если горизонтальная граница таблицы, 
            будет собрана один раз, а выводится будет одной строкой 
            1 балл, если построение каждой строки будет обернуто в отдельную функцию 
            2 балла, если построение всей таблицы будет проходить в рамках одного цикла, 
            а выбор, какую строку строить - при помощи case when
            */

            string inputString;
            string inputString2;
            string borderLine = "";

            do
            {
                do
                {
                    Console.Write("введите размерность таблицы: ");
                    inputString = Console.ReadLine();
                    if (!(int.TryParse(inputString, out var h)) || (h < 1) || (h >= 7))
                        Console.WriteLine("Размерность таблицы должна иметь числовое значение и находиться в диапазоне от 1 до 6. Повторите ввод.");
                } while (!(int.TryParse(inputString, out var c) && (c > 1) && (c < 7)));

                do
                {
                    Console.Write("введите произвольный текст: ");
                    inputString2 = Console.ReadLine();
                } while (inputString2 == "");
                if (int.Parse(inputString) + inputString2.Length > 40)
                    Console.WriteLine("Размер таблицы не может превышать 40 символов. Повторите ввод.");
            } while (int.Parse(inputString) + inputString2.Length > 40);
            

            var freeBorderStep = int.Parse(inputString);

            for (int i = 0; i < inputString2.Length + freeBorderStep * 2; i++)
            {
                borderLine += "+";
            }

            for (int step = 0; step < 7; step++)
            {
                switch (step % 2 * step)
                {
                    case 0:
                        {
                            Console.WriteLine(borderLine);
                        }
                        break;
                    case 1:
                        {
                            TableOnePrint(freeBorderStep, inputString2);
                        }
                        break;
                    case 3:
                        {
                            TableTwoPrint(freeBorderStep, inputString2);
                        }
                        break;
                    case 5:
                        {
                            TableThreePrint(freeBorderStep, inputString2);
                        }
                        break;
                }
            }

            /*Console.WriteLine(borderLine);
            TableOnePrint(freeBorderStep, inputString2);
            Console.WriteLine(borderLine);
            TableTwoPrint(freeBorderStep, inputString2);
            Console.WriteLine(borderLine);
            TableThreePrint(freeBorderStep, inputString2);
            Console.WriteLine(borderLine);*/
        }
        
        private static void TableOnePrint(int freeBorderStep, string inputString)
        {
            var tableHeight = freeBorderStep * 2 - 1;
            var tableWidth = freeBorderStep * 2 + inputString.Length;
            for (int i = 0; i < tableHeight; i++)
            {
                switch (i)
                {                    
                    case int k when k == freeBorderStep - 1: //строка с текстом
                        for (int j = 0; j < tableWidth; j++)
                        {
                            if (j == 0 || j == tableWidth - 1)
                                Console.Write("+");
                            else if (j == freeBorderStep)
                                Console.Write(inputString);
                            else if (j > freeBorderStep && j < tableWidth - freeBorderStep)
                                continue;
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        for (int j = 0; j < inputString.Length + freeBorderStep * 2; j++)
                        {
                            if (j == 0 || j == inputString.Length + freeBorderStep * 2 - 1)
                                Console.Write("+");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
        private static void TableTwoPrint(int freeBorderStep, string inputString)
        {
            var tableHeight = freeBorderStep * 2 - 1;
            var tableWidth = freeBorderStep * 2 + inputString.Length;

            for (int i = 0; i < tableHeight; i++)
            {
                var iEven = i % 2;
                switch (iEven)
                {
                    case 1:
                        for (int j = 0; j < tableWidth; j++)
                        {                            
                            if (j % 2 != 0 || j == 0 || j == tableWidth - 1)
                                Console.Write("+");
                            else
                                Console.Write(" ");

                        }
                        Console.WriteLine();
                        break;
                    default:
                        for (int j = 0; j < tableWidth; j++)
                        {
                            if (j % 2 == 0 || j == 0 || j == tableWidth - 1)
                                Console.Write("+");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
        private static void TableThreePrint(int freeBorderStep, string inputString)
        {
            var tableWidth = freeBorderStep * 2 + inputString.Length;
            for (int i = 0; i < tableWidth - 2; i++)
            {
                for (int j = 0; j < tableWidth; j++)
                {
                    if (j == i + 1 || j == 0 || j == tableWidth - 1 || j == tableWidth - i - 2)
                        Console.Write("+");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

    }
}
