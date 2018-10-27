using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Счастливое число определено следующим процессом. 
// Начиная с некоторого положительного целого числа, замените число суммой квадратов его цифр и повторяйте процесс до тех пор, пока число не будет равным одному(на чем все и остановится) 
// или оно будет циклиться бесконечно. Если цикл конечен, то изначальное число называется счастливым. Найдите первые 8 счастливых чисел.

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> happyNumbers = GetHappyNumbers();
            Console.WriteLine("Первые 8 счастливых чисел:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(happyNumbers[i]);
            }
        }

        static List<int> GetHappyNumbers()
        {
            List<int> happyNumbers = new List<int>();
            for (int i = 10; i < 100; i++)
            {
                int summ = GetSumm(i);
                if (summ == 1)
                {
                    happyNumbers.Add(i);
                }
                else
                {
                    continue;
                }
            }
            return happyNumbers;
        }

        static int GetSumm(int iteration)
        {
            string number = iteration.ToString();
            int counter = 0;
            List<int> numberList = number.Select(c => c - '0').ToList();
            List<int> wrongSumm = new List<int>();
            while (counter < 100)
            {
                int summ = GetPowSumm(numberList);
                if (summ == 1)
                {
                    return summ;
                }
                else if (wrongSumm.Contains(summ))
                {
                    return summ;
                }
                else
                {
                    wrongSumm.Add(summ);
                    numberList.Clear();
                    number = summ.ToString();
                    numberList = number.Select(c => c - '0').ToList();
                    counter++;
                }
            }
            return 0;
        }

        static int GetPowSumm(List<int> numberList)
        {
            double powSumm = 0;
            for (int j = 0; j < numberList.Count; j++)
            {
                powSumm += Math.Pow(numberList[j], 2);
            }
            return (int)powSumm;
        }

    }
}
