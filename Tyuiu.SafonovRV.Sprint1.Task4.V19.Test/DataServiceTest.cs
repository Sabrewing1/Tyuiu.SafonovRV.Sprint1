using Tyuiu.SafonovRV.Sprint1.Task4.V19.Lib;
namespace Tyuiu.SafonovRV.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 52;
            double y = 5;
            double wait = 1.14;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}