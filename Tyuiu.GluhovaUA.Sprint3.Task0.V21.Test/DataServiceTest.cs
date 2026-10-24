using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task0.V21.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 581.153;
            Assert.AreEqual(wait, res, 0.001);

        }
    }
}
    