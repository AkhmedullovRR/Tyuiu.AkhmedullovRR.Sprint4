using Tyuiu.AkhmedullovRR.Sprint4.Task6.V26.Lib;
namespace Tyuiu.AkhmedullovRR.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string[] array = ["Тюмень, Тамбов, Томск, Омск, Орёл"];
            string[] wait = ["Тюмень", "Тамбов", "Томск"];
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}