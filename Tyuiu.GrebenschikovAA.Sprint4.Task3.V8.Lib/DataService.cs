
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GrebenschikovAA.Sprint4.Task3.V8.Lib
{
    public class DataService: ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int c = 8;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 3] < c) c = array[i, 3];
            }
            return c;
        }
    }
}
