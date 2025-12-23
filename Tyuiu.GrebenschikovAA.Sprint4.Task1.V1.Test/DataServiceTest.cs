using Tyuiu.GrebenschikovAA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = 24;
            Assert.AreEqual(res, ds.Calculate(array));
        }
    }
}