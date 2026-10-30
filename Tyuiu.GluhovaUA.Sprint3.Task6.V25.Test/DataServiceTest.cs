using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task6.V25.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            double res = ds.GetSumTheDivisors(startValue,stopValue);
            double wait = 99;
            Assert.AreEqual(wait, res, 0.001);

        }
    }
}