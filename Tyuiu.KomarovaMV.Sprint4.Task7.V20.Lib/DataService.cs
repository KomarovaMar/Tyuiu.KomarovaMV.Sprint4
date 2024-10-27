using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomarovaMV.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i,j]=int.Parse(value.Substring(i*m+j,1));
                }
            }
            int sum = 1;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (result[i, j] % 2 == 0) { sum *= result[i, j]; }
                }
            }
            return sum;
        }
    }
}
