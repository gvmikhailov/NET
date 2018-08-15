using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// поиск наименьшего общего знаменателя

namespace CommonDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество общих знаменателей:");
            int counterCommonDenominators = Int32.Parse(Console.ReadLine());
            long biggestCommonDenominator = 1;
            int commonDenominator = 0;
            List<int> commonDenominators = new List<int>();
            Console.WriteLine("Введите общие знаменатели, нажимая ввод:");
            for (int i = 0; i < counterCommonDenominators; i++)
            {
                commonDenominators.Add(Int32.Parse(Console.ReadLine()));
                biggestCommonDenominator *= commonDenominators[i];
            }
            commonDenominators.Sort();
            // Console.WriteLine(biggestCommonDenominator);
            // Console.WriteLine(commonDenominators.First());
            for (int j = commonDenominators.First(); j <= biggestCommonDenominator; j++)            
            {
                int counter = 0;
                for (int k = 0; k < counterCommonDenominators; k++)
                {
                    if (j % commonDenominators[k] != 0)
                    {
                        counter += 1;
                    }
                    else
                    {                    
                        continue;
                    }
                }
                // Console.WriteLine(counter);
                if (counter != 0)
                {
                    continue;
                }
                else
                {
                    commonDenominator = j;
                    break;
                }
            }
            Console.WriteLine("Наименьший общий знаменатель - " + commonDenominator);
        }
    }
}
