using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GluhovaUA.Sprint3.Task5.V14.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task5.V14
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("*Выполнила: Глухова У. А.| ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Х = 5                                                                   *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;
            Console.WriteLine("Переменная Х " + x);
            Console.WriteLine("Старт шага первой суммы ряда " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда" + stopValue1);
            Console.WriteLine("Старт шага первой суммы ряда " + startValue2);
            Console.WriteLine("Конец шага первой суммы ряда" + stopValue2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Изменённая строка: " + ds.GetSumSumSeries( x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
