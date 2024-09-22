using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SafonovRV.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {

            double a = 5;
            double b = 32;
            double c = 9;


            return (int) (0.555556*(temp - b));
        }
    }
}
