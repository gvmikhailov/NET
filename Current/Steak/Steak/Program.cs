using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1820

namespace Steak
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int orderedSteaks = rnd.Next(1, 1001);
            Console.WriteLine("Количество заказанных бифштксов: {0}", orderedSteaks);
            int friedSteaks = rnd.Next(1, 1001);
            Console.WriteLine("Количество бифштксов, которые могут одновременно жариться: {0}", friedSteaks);
            Console.WriteLine("Бифштексы будут жариться: " + MinuteCounter(orderedSteaks, friedSteaks) + " минуты");
        }
        static double MinuteCounter (double orderedSteaks, double friedSteaks)
        {
            double time = (orderedSteaks / friedSteaks);
            double friedTime = Math.Ceiling(time);
            return friedTime;
        }
    }
}
