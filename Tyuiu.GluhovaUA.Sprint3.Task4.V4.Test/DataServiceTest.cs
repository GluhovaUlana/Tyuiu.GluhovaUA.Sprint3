using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task4.V4.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharOnNum()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -35.317;
            Assert.AreEqual(wait, res,0.001);

        }
    }
}