using Tyuiu.KomarovaMV.Sprint4.Task4.V7.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] x= new int[,] { { 4, 3, 6, 5, 5 }, { 3, 4, 4, 6, 4 }, { 6, 4, 6, 4, 5 }, { 5, 4, 4, 4, 5 }, { 3, 5, 6, 4, 6 } }; 
            Assert.AreEqual(39,ds.Calculate(x));
        }
    }
}