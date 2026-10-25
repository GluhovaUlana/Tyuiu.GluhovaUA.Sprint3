using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GluhovaUA.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k;
            for( k = startValue; k<=stopValue; k++)
            {
                sumSeries = sumSeries + ((Math.Pow(value, k)+(1.0/4.0)) * Math.Sin(k));
            }
            return Math.Round(sumSeries,3);
        }
    }
}
