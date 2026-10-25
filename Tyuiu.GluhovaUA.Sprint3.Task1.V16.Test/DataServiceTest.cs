using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task1.V16.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value,  startValue, stopValue);
            double wait = 15.948;
            Assert.AreEqual(wait, res);

        }
    }
}
