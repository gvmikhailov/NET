using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Разложение на произведение простых чисел

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(2, 10000);
            Console.WriteLine("Число, которое необходимо разложить на произведение простых чисел со степенями: {0}", number);
            List<int> primes = GetPrimes(number);
            List<int> primesFactors = GetPrimesFactors(number, primes);
            Console.WriteLine("Все простые числа множители:");
            foreach (int n in primesFactors)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            PrintResult(primesFactors);
        }

        static List<int> GetPrimes (int number)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 3; i < number; i += 2)
            {
                bool isPrime = false;
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime == true)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
       
        static List<int> GetPrimesFactors(int number, List<int> primes)
        {
            List<int> primesFactors = new List<int>();
            for (int i = 0; i < primes.Count; i++)
            {
                if (number % primes[i] == 0)
                {
                    number = number / primes[i];
                    if (number == 1)
                    {
                        primesFactors.Add(primes[i]);
                        break;
                    }
                    else
                    {
                        primesFactors.Add(primes[i]);
                        i = -1;
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            primesFactors.Sort();
            return primesFactors;
        }

        static void PrintResult(List<int> primesFactors)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (int m in primesFactors)
            {
                int result;
                if (counter.TryGetValue(m, out result))
                {
                    counter[m] += 1;
                }
                else
                { 
                    counter.Add(m, 1);
                }
            }
            Console.WriteLine("Простые множители со степенями:");
            foreach (var n in counter)
            {
                Console.WriteLine("Число {0} в степени {1}",n.Key, n.Value);
            }
            Console.WriteLine();
        }
    }
}
