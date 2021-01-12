using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFibonachi(5));
            Console.WriteLine(GetFibonachiRecursion(5));
        }

        static int GetFibonachiRecursion(int number) // recursion
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return GetFibonachiRecursion(number - 1) + GetFibonachiRecursion(number - 2);
            }
        }

        static int GetFibonachi(int number) // without recursion
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 0;
            int i = 0;

            while (i < number - 2)
            {
                num3 = num2 + num1;
                num1 = num2;
                num2 = num3;
                i += 1;
            }

            return num2;
        }

    }
}
