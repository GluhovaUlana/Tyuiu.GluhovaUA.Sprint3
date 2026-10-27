using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint3.Task3.V11.Lib;
namespace Tyuiu.GluhovaUA.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "s7wre7 v7w77 7";
            Assert.AreEqual(wait, res);

        }
    }
}