using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Введите число, и программа сгенерирует последовательность Фибоначчи до этого числа

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght = rnd.Next(0, 100);
            Console.WriteLine("Ряд Фибоначчи до {0} члена:", lenght);
            Fibonachi(lenght);
        }

        static void Fibonachi(int n)
        {
            ulong r1 = 0;
            ulong r2 = 1;
            ulong result = 0;

            if (n==1)
            {
                result = r1;
            }
            else if (n==2)
            {
                result = r2;
            }
            Console.Write(r1 + ", " + r2 + ", ");
            for (ulong i = 2; i < (ulong)n; i++)
            {
                result = r1 + r2;
                r1 = r2;
                r2 = result;
                Console.Write(result + ", ");
            }
        }
    }
}
