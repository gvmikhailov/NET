using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2012

namespace ResolvingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int countTasks = rnd.Next(1, 12);
            Console.WriteLine("За первый час Гриша решил {0} задач", countTasks);
            Console.WriteLine($"Остальные задачи он {InTimeOrNot(countTasks)} решить");
        }
        static string InTimeOrNot(int countTasks)
        {
            double resolvedTasks = 300 / (12 - countTasks);
            if (resolvedTasks < 45)
            {
                return "не успел";
            }
            return "успел";
        }
    }
}
