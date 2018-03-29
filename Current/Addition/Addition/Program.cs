using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1000

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 1001);
            int b = rnd.Next(0, 1001);
            Console.WriteLine($"Сумма чисел {a} и {b} равна {Addition(a, b)}");
        }
        public static int Addition(int a, int b)
        {
                return a + b;
        }
    }
}
