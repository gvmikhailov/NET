using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinFoThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(-100, 101);
            int number2 = rnd.Next(-100, 101);
            int number3 = rnd.Next(-100, 101);
            Console.Write("Число 1 = {0}, Число 2 = {1}, Число 3 = {2}", number1, number2, number3);
            Console.WriteLine();
            int minNumber = GetMinOfTripple(number1, number2, number3);
            Console.WriteLine("Минимальное число из трех = " + minNumber);
        }
        static int GetMinOfTripple (int a, int b, int c)
        {
            int minNumber = 0;
            int[] trippleNumbers = new int[3];
            trippleNumbers[0] = a;
            trippleNumbers[1] = b;
            trippleNumbers[2] = c;
            Array.Sort(trippleNumbers);
            minNumber = trippleNumbers[0];
            return minNumber;
        }
    }
}
