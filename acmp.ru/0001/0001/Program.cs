using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(0, 1000000000);
            int number2 = rnd.Next(0, 1000000000);
            Console.WriteLine("Сумма двух чисел {0} и {1} = {2}", number1, number2, GetSummOfTwoNumbers(number1, number2));
        }
        static int GetSummOfTwoNumbers(int number1, int number2)
        {
            int summOfTwoNumbers = number1 + number2;
            return summOfTwoNumbers;
        }
    }
}
