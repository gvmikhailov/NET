using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2066

namespace MinArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(0, 101);
            int number2 = rnd.Next(0, 101);
            int number3 = rnd.Next(0, 101);
            Console.WriteLine("Выбраны числа {0}, {1}, {2}", number1, number2, number3);
            int[] arrayOfNumbers = new[] { number1, number2, number3 };
            Array.Sort(arrayOfNumbers);
            int result = arrayOfNumbers[0] - arrayOfNumbers[1] * arrayOfNumbers[2];
            Console.WriteLine("Знаки расставлены таким образом, что минимальное арифметическое их:" + result);
        }
    }
}
