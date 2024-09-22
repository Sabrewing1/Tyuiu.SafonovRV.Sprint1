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
            double x = 5;
            double y = 4;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}