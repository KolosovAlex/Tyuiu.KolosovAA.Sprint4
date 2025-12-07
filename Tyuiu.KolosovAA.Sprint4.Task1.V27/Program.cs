using Tyuiu.KolosovAA.Sprint4.Task1.V27.Lib;


namespace Tyuiu.KolosovAA.Sprint4.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

        

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumOdd = ds.GetSumOddArrEl(array);

            Console.WriteLine("Сумма нечётных элементов = " + sumOdd);

            Console.ReadKey();
        }
    }
}