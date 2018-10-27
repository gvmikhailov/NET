using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2035

namespace TestRound
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int X = rnd.Next(1, 21);
            int Y = rnd.Next(1, 21);
            int summ = rnd.Next(2, 41);
            Console.WriteLine("Числа Х и У - " + X + " " + Y);
            Console.WriteLine("Сумма - " + summ);
            GetNumbers(X, Y, summ);
        }
        static void GetNumbers (int X, int Y, int summ)
        {
            int a = 0;
            int b = 0;
            if (X + Y < summ)
            {
                Console.WriteLine("impossible");
            }
            else if (X + Y == summ)
            {
                Console.WriteLine("Числа a и b - " + X + " " + Y);
            }
            else
            {
                a = X;
                b = Y;
                for (int i = 0; i < 100; i++)
                {
                    a = a - 1;
                    b = b - 1;
                    if (summ == 0)
                    {
                        a = 0;
                        b = 0;
                        Console.WriteLine("Числа a и b - " + a + " " + b);
                        break;
                    }
                    else if (a + b > summ)
                    {
                        continue;
                    }
                    else if (a + b < summ)
                    {
                        a = a + 1;
                        if (a < 0)
                        {
                            b = b + a;
                            a = 0;
                        }
                        else if (b < 0)
                        {
                            a = a + b;
                            b = 0;
                        }
                        Console.WriteLine("Числа a и b - " + a + " " + b);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Числа a и b - " + a + " " + b);
                        break;
                    }
                }
            }
        }
    }
}
