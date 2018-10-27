using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1493

namespace HappyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firtsTriple = new int[3];
            int[] secondTriple = new int[3];
            int summfirtsTriple = 0;
            int summSecondTriple = 0;
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                firtsTriple[i] = rnd.Next(0, 10);
                summfirtsTriple += firtsTriple[i];
                Console.Write(firtsTriple[i] + ", ");
            }
            if (summfirtsTriple % 2 == 0)
            {
                summSecondTriple = summfirtsTriple + 1;
            }
            else
            {
                summSecondTriple = summfirtsTriple - 1;
            }
            Console.WriteLine();
            Console.WriteLine(summfirtsTriple + " " + summSecondTriple);
            if (summSecondTriple < 10)
            {
                int firstDigit = rnd.Next(0, 6);
                int secondDigit = rnd.Next(0, 6);
                int thirdDigit = summSecondTriple - firstDigit - secondDigit;
                Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit);
                secondTriple = new int[] { firstDigit, secondDigit, thirdDigit };
            }
            if (summSecondTriple >= 10 && summSecondTriple <= 20)
            {
                int firstDigit = rnd.Next(3, 6);
                int secondDigit = rnd.Next(3, 6);
                int thirdDigit = summSecondTriple - firstDigit - secondDigit;
                Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit);
                secondTriple = new int[] { firstDigit, secondDigit, thirdDigit };
            }
            if (summSecondTriple > 20)
            {
                int firstDigit = rnd.Next(9, 10);
                int secondDigit = rnd.Next(9, 10);
                int thirdDigit = summSecondTriple - firstDigit - secondDigit;
                Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit);
                secondTriple = new int[] { firstDigit, secondDigit, thirdDigit };
            }
            summSecondTriple = 0;
            for (int l = 0; l < 3; l++)
            {
                summSecondTriple += secondTriple[l];
            }
            if (summfirtsTriple == summSecondTriple - 1 || summfirtsTriple == summSecondTriple + 1)
            {
                Console.WriteLine("Счастливый билет :)");
            }
            else
            {
                Console.WriteLine("Не счастливый билет :(");
            }
        }
    }
}
