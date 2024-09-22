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

            double a = 0;
            double b = 0;
            double c = 0;



            Console.WriteLine("Введите значение стороны прямоугольника A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение стороны прямоугольника B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение стороны квадрата С:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Количество квадратов  = " + ds.HowManySquares(a,b,c));


            Console.ReadLine();
        }
    }
}
