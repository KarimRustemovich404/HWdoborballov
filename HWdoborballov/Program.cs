using System;

namespace HWdoborballov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Программа демонстрирует размер бриллианта.\nВведите нужный Вам размер бриллианта, пожалуйста (1,3,7):");
            string size = Console.ReadLine();
            int num;

            if (int.TryParse(size, out num)) ;
            {
                if (num < 0 || num % 2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Null :3");
                }
                else
                {
                    switch (num)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ваш размер - 1. Бриллиант будет выглядеть так:\n\n*\n");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ваш размер - 3. Бриллиант будет выглядеть так:\n\n *\n***\n *\n");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Ваш размер - 5. Бриллиант будет выглядеть так:\n\n  *\n ***\n*****\n ***\n  *\n");
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Ваш размер - 7. Бриллиант будет выглядеть так:\n\n   *\n  ***\n *****\n*******\n *****\n  ***\n   *\n");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такого размера нет ;((");
                            break;
                    }
                }
            }
            Console.WriteLine("Нажмите ВВОД, чтобы завершить выполнение программы :]");
            Console.ReadKey();
        }
    }
}
