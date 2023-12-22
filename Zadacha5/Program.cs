using System;
using System.Collections.Generic;

namespace Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 5. Программа ищет ближайшее к нулю значение из следующего списка:\n");

            List<int> numbers = new List<int>() { 1, 23, 543, -12223, -94, 234, -1, 0 };
            int closestToZero = numbers[0];
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nТкните ВВОД, чтобы найти ближайшее число к нулю");
            Console.ReadKey();

            foreach (int number in numbers)
            {
                if (Math.Abs(number) < Math.Abs(closestToZero))
                {
                    closestToZero = number;
                }
                else if (Math.Abs(number) == Math.Abs(closestToZero) && number != 0)
                {
                    closestToZero = number;
                }
            }

            Console.WriteLine("\nБлижайшее к нулю число: " + closestToZero + "\nНажмите ВВОД, чтобы завершить выполнение программы :3");
            Console.ReadKey();
        }
    }
}
