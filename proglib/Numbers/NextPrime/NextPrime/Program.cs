using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Программа находит простые числа до тех пор, пока пользователь перестанет спрашивать. 

namespace NextPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> primes = new List<ulong>();
            primes.Add(2);
            Console.WriteLine("Список простых чисел. Для следующего числа нажмите \"Пробел\", для выхода из программы нажмите \"Escape\":");
            Console.WriteLine(" 2");
            for (ulong i = 3; i <= 18446744073709551615; i += 2)
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
                while (isPrime == true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        primes.Add(i);
                        Console.WriteLine(i);
                        break;
                    }
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    { 
                        Environment.Exit(0);
                    }          
                }
            }
        }
    }
}
