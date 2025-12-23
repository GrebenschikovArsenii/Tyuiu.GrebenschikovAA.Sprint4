using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task6.V3.Lib
{
    public class DataService: ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            int result = 0;
            foreach (string name in array)
            {
                if (name.Length < 6) result++;
            }
            return result;
        }
    }
}
