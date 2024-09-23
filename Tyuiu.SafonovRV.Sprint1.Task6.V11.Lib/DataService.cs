using System.ComponentModel;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SafonovRV.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            value.LastIndexOf(value[0]);

            if (value.LastIndexOf(value[0]) > 0)
            {
                return true;
            }
            return false;

        }
    }
}
