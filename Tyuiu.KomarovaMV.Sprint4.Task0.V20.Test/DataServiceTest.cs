using Tyuiu.KomarovaMV.Sprint4.Task0.V20.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int res=ds.GetMultEvenArrEl(m);
            Assert.AreEqual(24576, res);
        }
    }
}