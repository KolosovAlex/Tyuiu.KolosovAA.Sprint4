using Tyuiu.KolosovAA.Sprint4.Task7.V4.Lib;

DataService dataService = new DataService();


Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 382976421897                                                         *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

string value = "382976421897";
int n = 3;
int m = 4;

int sumOfOddNumbers = dataService.Calculate(n, m, value);

Console.WriteLine($"Сумма нечетных чисел: {sumOfOddNumbers}");
Console.WriteLine("************************************************************************");
Console.ReadLine();