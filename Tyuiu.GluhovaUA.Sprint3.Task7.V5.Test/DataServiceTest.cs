using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task7.V5.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] g;
            g = new double[len];
            g[0] = -174.86;
            g[1] = -112.79;
            g[2] = -63.95;
            g[3] = -28.04;
            g[4] = -5.52;
            g[5] = 1.00;
            g[6] = -6.06;
            g[7] = -28.16;
            g[8] = -63.96;
            g[9] = -112.77;
            g[10] = -174.83;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(len, res.Length);

        }
    }
}