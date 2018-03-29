using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabotage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arrayLenght = rnd.Next(0, 25000);
            int[] input = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                input[i] = rnd.Next(0, 25000);
                Console.Write(input[i] + ", ");
            }
            Array.Sort(input);
            Array.Reverse(input);
            Console.WriteLine();
            foreach (int m in input)
            {
                Console.Write(m + ", ");
            }
        }
    }
}
