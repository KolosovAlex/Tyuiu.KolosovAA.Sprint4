using System;
using Tyuiu.KolosovAA.Sprint4.Task6.V13.Lib;

namespace Tyuiu.KolosovAA.Sprint4.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cars = ["Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"[{i}] = {cars[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(cars);

            Console.WriteLine($"Количество элементов с длиной больше 4: {result}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}