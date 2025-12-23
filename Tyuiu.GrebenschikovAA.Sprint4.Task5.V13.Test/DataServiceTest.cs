using Tyuiu.GrebenschikovAA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,]
            {
                {1, 6, -5, -4, 9 },
                {1, -6, -5, -4, -9 },
                {-1, 6, -5, -4, 9 },
                {1, 6, -5, -4, 9 },
                {1, -6, -5, -4, 9 }
            };
            int res = ds.Calculate(arr);
            Assert.AreEqual(14, res);
        }
    }
}