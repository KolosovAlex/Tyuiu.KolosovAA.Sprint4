using Tyuiu.KolosovAA.Sprint4.Task3.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] array = new int[,] {
                { 8, 7, 7, 8, 5 },
                { 4, 3, 5, 3, 6 },
                { 5, 3, 8, 6, 3 },
                { 6, 3, 8, 5, 4 },
                { 3, 6, 8, 3, 4 }
        };
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.Calculate(array);
        Console.WriteLine($"Мнимальный элемент первого столбца: {res}");
        Console.ReadKey();
    }
}