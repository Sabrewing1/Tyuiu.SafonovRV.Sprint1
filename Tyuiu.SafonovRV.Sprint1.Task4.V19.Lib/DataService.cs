using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SafonovRV.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            var res = (5+4)/Math.Abs(5-2);
            return res;
        }
    }
}
