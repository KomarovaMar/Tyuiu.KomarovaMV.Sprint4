using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomarovaMV.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int max = int.MinValue;
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;
            for (int j = 0; j < cols; j++)
            {
                if (array[0, j] > max) { max = array[0, j]; }

            }
            return max;
        }
    }
}
