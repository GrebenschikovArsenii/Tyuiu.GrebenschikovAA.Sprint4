using Tyuiu.GrebenschikovAA.Sprint4.Task4.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[,] arr =
            {
                {5, 7, 7, 8, 5 },
                {6, 5, 6, 8, 6 },
                {7, 6, 8, 8, 5 },
                {7, 6, 7, 8, 6 },
                {7, 6, 7, 7, 5 }
            };
            int res = ds.Calculate(arr);
            Assert.AreEqual(81, res);
        }
    }
}