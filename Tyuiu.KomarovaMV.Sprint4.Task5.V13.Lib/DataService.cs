using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomarovaMV.Sprint4.Task5.V13.Lib
{
    public class DataService : ISprint4Task5V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length/rows;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
         return matrix;

        }
    }
}
