using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1636

namespace FineTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int fineTimeQXX = rnd.Next(1, 501);
            Console.WriteLine("Штрафное время в минутах команды QXX - {0}", fineTimeQXX);
            int fineTimeZZZ = rnd.Next(600, 1001);
            Console.WriteLine("Штрафное время в минутах команды ZZZ - {0}", fineTimeZZZ);
            int[] fineScoreZZZ = new int[10];
            for (int i = 0; i < 10; i++)
            {
                fineScoreZZZ[i] = rnd.Next(0, 5);
                Console.Write(fineScoreZZZ[i] + ", ");
            }
            Console.WriteLine();
            PrintCause(fineTimeQXX, fineTimeZZZ, fineScoreZZZ);
        }
        static void PrintCause (int fineTimeQXX, int fineTimeZZZ, int[] fineScoreZZZ)
        {
            int summfineScoreZZZ = fineScoreZZZ.Sum();
            Console.WriteLine("Сумма штрафных баллов команды ZZZ - " + summfineScoreZZZ);
            int summfineTimeZZZ = summfineScoreZZZ * 20;
            int summfineTimeZZZWithoutMistakes = fineTimeZZZ - summfineTimeZZZ;
            if (summfineTimeZZZWithoutMistakes > fineTimeQXX)
            {
                Console.WriteLine("No chance.");
            }
            else
            {
                Console.WriteLine("Dirty debug :(");
            }
        }
    }
}
