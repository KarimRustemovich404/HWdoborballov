using System;
using System.Collections.Generic;
using System.Linq;

namespace DoborBallov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2. Программа сортирует следующий массив строк в порядке возрастания\n");

            string[] array = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\nНажмите ВВОД, чтобы отсортировать массив :3");
            Console.ReadKey();
            Console.Clear();

            IEnumerable<string> enumerable = from word in array orderby word.Length select word;
            Console.WriteLine("Отсортированный массив:\n");
            foreach (string item in enumerable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nНажмите ВВОД, чтобы завершить выполнение прогграммы :Ъ");
            Console.ReadKey();
        }
    }
}
