using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1068

namespace SummInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int summ = 0;
            int n = rnd.Next(-10000, 10001);
            if (n <= 1)
            {
                for (int i = n; i <= 1; i++)
                    summ += i;
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    summ += j;
                }
            }
            Console.WriteLine($"Сумма всех целых чисел, лежащих между 1 и {n} включительно - {summ}");
        }
    }
}
