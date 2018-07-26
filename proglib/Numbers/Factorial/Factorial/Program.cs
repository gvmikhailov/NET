using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Решение с помощью циклов и отдельно с помощью рекурсии Факториал числа

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(0, 21);
            Console.WriteLine("Факториал числа {0}, посчитаный через рекурсию - {1}", length, GetFactorialRecursive(length));
            Console.WriteLine("Факториал числа {0}, посчитаный через цикл - {1}", length, GetfactorialMath(length));
        }

        static ulong GetFactorialRecursive(int x)
        {
            ulong factorial = 1;
            if (x == 0)
            {
                factorial = 1;
            }
            else
            {
                factorial = (ulong)x * GetFactorialRecursive(x - 1);
            }
            return factorial;
        }

        static ulong GetfactorialMath(int x)
        {
            ulong factorial = 1;
            if (x == 0)
            {
                factorial = 1;
            }
            else
            {
                for (ulong i = 1; i <= (ulong)x; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
