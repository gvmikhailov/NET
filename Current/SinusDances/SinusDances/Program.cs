using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1149

namespace SinusDances
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 201);
            int n = count;
            string piece = "";
            string summPiece = "";
            string braket = "";
            string aN = "";
            string sign = "";
            string braket1 = "";
            string braket2 = "";
            string sN = "";
            for (int i = 1; i <= count; i++)
            {
                if (i == 1)
                {
                    sign = "";
                }
                else if (i % 2 == 0)
                {
                    sign = "-";
                }
                else
                {
                    sign = "+";
                }
                piece = "sin(" + i;
                summPiece = summPiece + sign + piece;
                braket = braket + ")";
                aN = summPiece + braket;
                //Console.WriteLine(aN);

                braket1 = braket1 + "(";
                if (n == 1)
                {
                    sN = sN + aN + "+" + n;
                }
                else
                {
                    sN = sN + aN + "+" + n + ")";
                }
                n = n - 1;
            }
            for (int j = 1; j < count; j++)
            {
                braket2 = braket2 + "(";
            }
            Console.WriteLine(braket2 + sN);
        }
    }
}
