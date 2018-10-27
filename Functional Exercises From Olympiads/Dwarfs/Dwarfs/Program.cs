using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1243

namespace Dwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int propertyCounter = rnd.Next(1, 1000000001);
            Console.WriteLine("Число одинаковых вещей, которые хотят поделить гномы - {0}", propertyCounter);
            int dowry = propertyCounter % 7;
            Console.WriteLine("Белоснежка получит {0} вещей", dowry);
        }
    }
}
