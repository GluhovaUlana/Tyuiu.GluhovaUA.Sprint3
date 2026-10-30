using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint3.Task4.V4.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнила: Глухова У. А.| ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор break and contiune                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для функции res += Math.Sin(x) + (2 / startValue2)   *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue =-5;
            int stopValue = 5;

            Console.WriteLine("Старт шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Изменённая строка: " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}