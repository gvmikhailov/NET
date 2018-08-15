using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1293

namespace Spraying
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 101);
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101);
            Console.WriteLine($"Для напыления {n} прямоугольных панелей со сторонами {a} и {b} потребуется {SqareCounter(n, a, b)} нанограмм сульфида тория");
        }
        static int SqareCounter(int n, int a, int b)
        {
            if ((n <= 1 || n >= 100) || (a <= 1 || a >= 100) || (b <= 1 || b >= 100))
            {
                return -1;
            }
            return a * b * n * 2;
        }
    }
}
