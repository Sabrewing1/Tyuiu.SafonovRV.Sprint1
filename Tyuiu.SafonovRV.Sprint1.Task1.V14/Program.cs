using Tyuiu.SafonovRV.Sprint1.Task1.V14.Lib;
namespace Tyuiu.SafonovRV.Sprint1.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #1 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* спринт #1                                                               *");
                Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
                Console.WriteLine("* Задание #1                                                              *");
                Console.WriteLine("* Вариант #14                                                             *");
                Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУб-24-1                       *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
                Console.WriteLine("* вычисляет результат по формуле a*b/c+(a/(b+c)) и печатает его на экране.*");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("* a*b/c+(a/(b+c))                                                         *");
                Console.WriteLine("***************************************************************************");
                

                double a, b, c;
                Console.WriteLine("Введите значение a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение b");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение c");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.Calculate(a,b,c));

                Console.ReadLine();
            }
        }
    }
}
