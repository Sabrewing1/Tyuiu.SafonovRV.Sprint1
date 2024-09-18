using Tyuiu.SafonovRV.Sprint1.Task1.V14.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 1;
            double c = 1;
            var res = ds.Calculate(a,b,c);
            Assert.AreEqual(1.5, res);

        }
    }
}