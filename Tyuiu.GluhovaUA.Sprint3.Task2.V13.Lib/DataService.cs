using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GluhovaUA.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            do
            {
                s = s + (Math.Pow(value, startValue) + (2.0 / (startValue + 1.0))) * Math.Sin(value);
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(s,3);
            
        }
    }
}
