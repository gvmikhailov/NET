using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReductionOfFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель:");
            int numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель:");
            int denominator = Int32.Parse(Console.ReadLine());
            TakeReductionOfFractions(numerator, denominator);
        }
        static void TakeReductionOfFractions (int numerator, int denominator)
        {
            int endOfCycle = denominator >= numerator ? denominator : numerator;
            List<int> denominators = new List<int>();
            List<int> numerators = new List<int>();
            for (int i = 1; i < endOfCycle; i++)
            {
                if (denominator % i == 0 && numerator % i == 0)
                {
                    denominators.Add(denominator / i);
                    numerators.Add(numerator / i);                                  
                }
            }
            int reductionNumerator = numerators.Min();
            int reductionDenominator = denominators.Min();
            Console.WriteLine("Сокращенная дробь - {0} / {1}", reductionNumerator, reductionDenominator);
        }
    }
}
