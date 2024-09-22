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
            double a = 10;
            double b = 10;
            double c = 5;
            double wait = 4;
            var res = ds.HowManySquares(a,b,c);
            Assert.AreEqual(wait,res);
        }
    }
}