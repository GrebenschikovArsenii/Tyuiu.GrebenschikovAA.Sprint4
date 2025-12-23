using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task7.V18.Lib
{
    public class DataService: ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[5 * i + j].ToString());
                    if (matrix[i, j] % 2 == 0) c *= matrix[i, j];
                }
            }
            return c;
        }
    }
}
