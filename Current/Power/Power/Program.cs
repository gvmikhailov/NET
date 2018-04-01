using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1110

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int power = rnd.Next(0, 1000);
            Console.WriteLine("Степень числа Х - {0}", power);
            int denominator = rnd.Next(1, 1000);
            Console.WriteLine("Делитель - {0}", denominator);
            int remainderOfDivision = rnd.Next(0, 1000);
            Console.WriteLine("Остаток от деления - {0}", remainderOfDivision);
            GetResults(power, denominator, remainderOfDivision);
        }
        static void GetResults (int power, int denominator, int remainderOfDivision)
        {
            List<double> results = new List<double>();
            for (int i = 0; i < denominator - 1; i++)
            {
                double result = Math.Pow(i, power) % denominator;
                if (result == remainderOfDivision)
                {
                    results.Add(i);
                }
                else
                {
                    continue;
                }
            }
            results.Sort();
            if (results.Any())
            {
                Console.WriteLine("Результаты:");
                foreach (int m in results)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Нет результатов");
            }
        }
    }
}
