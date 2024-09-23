using Tyuiu.SafonovRV.Sprint1.Task6.V11.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strtest = "муму";
            var dataService = new DataService();
            bool res = dataService.CheckeFirstLetterRepetition(strtest);   
            
            Assert.AreEqual (res,true);
        }
    }
}