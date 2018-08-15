using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1209

namespace PowerOfDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPowerOfTen = 15;
            int placeCypher = 56;
            string row = "";
            for (double i = 1; i < endPowerOfTen; i++)
            {
                double rowDouble = Convert.ToInt64(Math.Pow(10, i));
                string rowString = rowDouble.ToString();
                row += rowString;
            }
            Console.WriteLine(row.Substring(placeCypher - 1, 1));
        }
    }
}
