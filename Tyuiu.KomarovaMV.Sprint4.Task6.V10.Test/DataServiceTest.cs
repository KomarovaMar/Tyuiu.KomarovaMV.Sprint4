using Tyuiu.KomarovaMV.Sprint4.Task6.V10.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] i = { "�����", "����", "�����", "����", "�������", "�������", "��������" };
            string[] j = ds.Calculate(i);
            string[] k = { "�����", "����", "�����", "����" };
            CollectionAssert.AreEqual(k, j);
        }
    }
}