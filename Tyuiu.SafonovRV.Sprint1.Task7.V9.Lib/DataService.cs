using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SafonovRV.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            double e = Math.Pow(2.71828184590452353602874713527, x);
            z = Math.Round(e - (Math.Pow(y, 2) + (Math.Pow (Math.Cos(x),3)) + ((12*x*y) - 3*Math.Pow(x,2))) / (Math.Cos(Math.Pow(x, 3) + 3) + 18*y - 1) +0.001,3);
            return z;
        }
    }
}
