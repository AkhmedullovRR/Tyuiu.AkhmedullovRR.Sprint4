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
            string[] array = ["������, ������, �����, ����, ���"];
            string[] wait = ["������", "������", "�����"];
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}