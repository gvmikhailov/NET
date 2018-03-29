using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerOrLess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(-1000000000, 1000000000);
            int number2 = rnd.Next(-1000000000, 1000000000);
            Console.WriteLine("{0} {1} {2}", number1, GetСomparison(number1, number2), number2); 
        }
        static char GetСomparison (int number1, int number2)
        {
            char sign = ' ';
            if (number1 == number2 )
            {
                sign = '=';
            }
            else if (number1 > number2)
            {
                sign = '>';
            }
            else
            {
                sign = '<';
            }
            return sign;
        }
    }
}
