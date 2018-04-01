using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1327

namespace Fuses
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstDay = rnd.Next(1, 5001);
            Console.WriteLine("Первый по счету день в интервале - {0}", firstDay);
            int lastDay = rnd.Next(5000, 10001);
            Console.WriteLine("Последний по счету день в интервале - {0}", lastDay);
            GetNumberOfFuses(firstDay, lastDay);
        }
        static void GetNumberOfFuses (int firstDay, int lastDay)
        {
            int counterOfFuse = 0;
            for (int i = firstDay; i <= lastDay; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    counterOfFuse += 1;
                }
            }
            Console.WriteLine("Необходимо запастись {0} предохранителями", counterOfFuse);
        }
    }
}
