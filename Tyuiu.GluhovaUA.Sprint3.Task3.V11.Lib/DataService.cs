using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GluhovaUA.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            
            foreach(char i in value)
            {
                if (i == replaceable)
                {
                    value = value.Replace(replaceable, replacement);
                }
            }
            return value;
        }
    }
}