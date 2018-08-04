using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Нахождение простых чисел до n с помощью Решета Эратосфена

namespace EratosthenesSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lastPrime = rnd.Next(3, 1001);
            List<int> numbers = new List<int>();
            numbers.Add(2);
            for (int i = 3; i < lastPrime; i += 2)
            {
                numbers.Add(i);
            }

            Console.WriteLine("Простые числа до {0}, полученые c помощью решета Эратосфена:", lastPrime);
            PrintPrimes(numbers);
        }

        static void PrintPrimes(List<int> numbers)
        {
            for (int j = 1; j < numbers.Count; j++)
            {
                if (Math.Pow(j, 2) < numbers[numbers.Count - 1])
                {
                    for (int k = (j + 1); k < numbers.Count; k++)
                    {
                        if (numbers[k] % numbers[j] == 0)
                        {
                            numbers.RemoveAt(k);
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            foreach (int m in numbers)
            {
                Console.WriteLine(m);
            }
        }
    }
}
