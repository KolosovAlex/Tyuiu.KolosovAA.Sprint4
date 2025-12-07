using Tyuiu.KolosovAA.Sprint4.Task0.V12.Lib;

namespace Tyuiu.KolosovAA.Sprint4.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            DataService ds = new DataService();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.GetMultEvenArrEl(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}