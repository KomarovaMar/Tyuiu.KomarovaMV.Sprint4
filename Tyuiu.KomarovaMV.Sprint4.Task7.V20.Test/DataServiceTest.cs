using Tyuiu.KomarovaMV.Sprint4.Task7.V20.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int res = 30;
            string x = "357951248632587";
            int n = 5;
            int m = 3;
            int y=ds.Calculate(n, m,x);
            Assert.AreEqual(res,y);
        }
    }
}