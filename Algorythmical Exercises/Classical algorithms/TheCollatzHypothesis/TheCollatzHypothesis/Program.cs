using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Гипотеза Коллатца - число шагов, за которые получится единица.

namespace TheCollatzHypothesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(2, 1000001);
            Console.WriteLine("Число шагов, за которые из числа {0} по гипотезе Коллатца получится 1:", number);
            GetCountCollatzSteps(number);
        }

        static void GetCountCollatzSteps(int number)
        {
            int count = 0;
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    count++;
                }
                else
                {
                    number = (number * 3) + 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
