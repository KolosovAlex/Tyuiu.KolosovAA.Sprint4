using System;
using Tyuiu.KolosovAA.Sprint4.Task6.V13.Lib;
namespace Tyuiu.KolosovAA.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
     
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [ Ford, Toyota, Honda, Mercedes, BMW, Audi] *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых   *");
            Console.WriteLine("* больше 4.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив [ Ford, Toyota, Honda, Mercedes, BMW, Audi]                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] matrix = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            Console.WriteLine(ds.Calculate(matrix));
            Console.ReadKey();
        }
    }
}