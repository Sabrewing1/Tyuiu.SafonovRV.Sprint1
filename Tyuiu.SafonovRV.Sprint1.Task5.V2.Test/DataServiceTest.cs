using Tyuiu.SafonovRV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 5;
            DataService ds = new DataService();
            double   res  = ds.FahrenheitToĐelsius(temp);
            Assert.AreEqual(-6, res);
            {
            }
        }
    }
}