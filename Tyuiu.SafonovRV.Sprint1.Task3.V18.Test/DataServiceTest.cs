using Tyuiu.SafonovRV.Sprint1.Task3.V18.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
         DataService ds = new DataService();
            double a = 4;
            double b = 2;
            double c = 4;
            double wait = 32;
            var res = ds.HowManySquares(a,b,c);
            Assert.AreEqual(wait,res);
        }
    }
}