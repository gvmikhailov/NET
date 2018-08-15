using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1224

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            long n = rnd.Next(1, 11);
            long m = rnd.Next(1, 11);
            Console.WriteLine("Задана матрица {0}x{1}", n, m);
            long a = n * 2 - 2;
            long b = m * 2 - 1;
            if (a<=b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
