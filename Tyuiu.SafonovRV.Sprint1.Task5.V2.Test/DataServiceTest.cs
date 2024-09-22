using Tyuiu.SafonovRV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 70;
            DataService ds = new DataService();
            double   res  = ds.FahrenheitTo—elsius(temp);
            Assert.AreEqual(4, res);
            {
            }
        }
    }
}