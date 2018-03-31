using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1924

namespace GrimmyOrBlack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 51);
            Console.WriteLine("Числа от 1 до {0}", a);
            TakeWinner(a);
        }
        static void TakeWinner (int a)
        {
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("Выиграли черные");
            }
            else
            {
                Console.WriteLine("Выиграли чумазые");
            }
        }
    }
}
