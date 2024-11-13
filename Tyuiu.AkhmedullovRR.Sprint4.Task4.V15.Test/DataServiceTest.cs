using Tyuiu.AkhmeduloovRR.Sprint4.Task4.V15.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            int[,] A = new int[5, 5] {
               { 4, 2, 5, 5, 3, },
               { 4, 2, 5, 2, 2, },
               { 3, 2, 4, 2, 4, },
               { 3, 6, 4, 5, 4, },
               { 2, 4, 6, 4, 2, }
            };

            var R = DS.Calculate(A);
            Assert.AreEqual(R, 49);
        }
    }
}