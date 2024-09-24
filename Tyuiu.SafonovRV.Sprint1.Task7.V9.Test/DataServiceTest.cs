using Tyuiu.SafonovRV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.SafonovRV.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 5.99;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
            
            
        }
    }
}