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
            double a = 9;
            double b = 9;
            double c = 3;
            double wait = 243;
            var res = ds.HowManySquares(a,b,c);
            Assert.AreEqual(wait,res);
        }
    }
}