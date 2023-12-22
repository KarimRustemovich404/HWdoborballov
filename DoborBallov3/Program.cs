using System;

namespace DoborBallov3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 3. Программа расшираяет функциональность встроенного класса.");
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array newArray = new Array(arrayOfNumbers);
            Console.WriteLine("\nВведите Square, Cube, Avarage, Sum, Even или Odd для вызова соответствующего метода");
            string arr = Console.ReadLine();
            switch (arr)
            {
                case "Square":
                    Console.Clear();
                    Console.WriteLine("Метод возводит все числа массива в квадрат\n");
                    newArray.Square();
                    break;

                case "Cube":
                    Console.Clear();
                    Console.WriteLine("Метод возводит все числа массива в куб\n");
                    newArray.Cube();
                    break;

                case "Avarage":
                    Console.Clear();
                    Console.WriteLine("Разработчику не хватило мозгов, чтобы описать данный метод :(");
                    newArray.Avarage();
                    break;

                case "Sum":
                    Console.Clear();
                    Console.WriteLine("Тут как-то сложно получилось и метод не вызывается");
                    break;

                case "Even":
                    Console.Clear();
                    Console.WriteLine("Разработчику не хватило мозгов, чтобы описать данный метод ;((");
                    break;

                case "Odd":
                    Console.Clear();
                    Console.WriteLine("Разработчику не хватило мозгов, чтобы описать данный метод :-(");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Кажется, Вы неверно ввели название метода ~_~");
                    break;

            }
            Console.WriteLine("\nНажмите ВВОД, чтобы завершить выполнение программы :3");
            Console.ReadKey();
        }
    }
}
