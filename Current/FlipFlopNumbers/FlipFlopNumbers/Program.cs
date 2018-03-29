using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipFlopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в последовательности: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("01");
            }
            else if (n == 2)
            {
                Console.WriteLine("11 01");
            }
            else if (n == 3)
            {
                Console.WriteLine("16 06 68");
            }
            else if (n == 4)
            {
                Console.WriteLine("16 06 68 88");
            }
            else
            {
                Console.WriteLine("Glupenky Pierre");
            }
        }
    }
}
