using System.Reflection.Metadata;
using Tyuiu.SafonovRV.Sprint1.Task3.V18.Lib;

namespace Tyuiu.SafonovRV.Sprint1.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет,сколько квадратов C можно         *");
            Console.WriteLine("* разместить внутри прямоугольника с размерами A x B без наложений        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 9;
            double b = 9;
            double c = 3;
             
            Console.WriteLine("Сторона A прямоугольника = " + a);
            Console.WriteLine("Сторона B прямоугольника = " + b);
            Console.WriteLine("Сторона C прямоугольника = " + c);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Площадь прямоугольника  = " + ds.HowManySquares(a,b,c));


            Console.ReadLine();
        }
    }
}
