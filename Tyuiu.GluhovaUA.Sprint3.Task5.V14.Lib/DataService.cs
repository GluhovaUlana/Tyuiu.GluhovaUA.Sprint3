using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GluhovaUA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    res += Math.Sin(x) + (2 / startValue2);
                }
            }
            return Math.Round(res,3);
        }
    }
}
