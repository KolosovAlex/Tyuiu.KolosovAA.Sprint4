using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolosovAA.Sprint4.Task4.V10.Lib;
namespace Tyuiu.KolosovAA.Sprint4.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {



            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите кол-во строк и столбцов через enter");
            int rows = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, length];

            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("Ваш массив");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(array);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}