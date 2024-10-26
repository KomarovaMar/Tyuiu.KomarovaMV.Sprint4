using Tyuiu.KomarovaMV.Sprint4.Task5.V13.Lib;
namespace Tyuiu.KomarovaMV.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] data = new int[,] { { 1, -2 }, { -3, 4 } };
            int[,] res=ds.Calculate(data);
            int[,] x= new int[,] { {1,0 }, { 0, 4 } };
            CollectionAssert.AreEqual(x, res);
        }
    }
}