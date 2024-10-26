using Tyuiu.KomarovaMV.Sprint4.Task2.V22.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = new int[] { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(m);
            Assert.AreEqual(375, res);
        }
    }
}