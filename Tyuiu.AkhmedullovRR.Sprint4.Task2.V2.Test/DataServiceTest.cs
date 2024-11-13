
using Tyuiu.AkhmedullovRR.Sprint4.Task2.V2.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[11] { 3, 4, 2, 1, 2, 4, 5, 3, 4, 4, 5, };
            var res = ds.Calculate(array);
            var wait = 225;
            Assert.AreEqual(res, wait);
        }
    }
}