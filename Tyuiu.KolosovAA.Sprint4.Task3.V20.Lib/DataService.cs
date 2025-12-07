using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KolosovAA.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] arrays)
        {
            int rows = arrays.GetUpperBound(0) + 1;
            int columns = arrays.Length / rows;
            bool f = false;
            int b = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (f == false)
                    {
                        f = true;
                        b = arrays[i, j];
                        break;
                    }
                    else if (arrays[i, j] < b)
                    {
                        b = arrays[i, j];
                    }
                    break;
                }
            }
            return b;
        }
    }
}