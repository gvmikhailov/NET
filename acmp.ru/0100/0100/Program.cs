using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfTicketDigits = rnd.Next(2, 20);
            if (numberOfTicketDigits % 2 != 0)
            {
                numberOfTicketDigits += 1;
            }
            Console.WriteLine("Количество цифр в билете - {0}", numberOfTicketDigits);
            GetNumbersOfLuckyTickets(numberOfTicketDigits);
        }
        static void GetNumbersOfLuckyTickets (int numberOfTicketDigits)
        {
            int[] digits = new int[numberOfTicketDigits];
            string iterationCounterString = new String('9', numberOfTicketDigits);
            int iterationCounter = Convert.ToInt32(iterationCounterString, 10);
            //Console.WriteLine(iterationCounter);
            for (long i = 0; i <= iterationCounter; i++)
            {

            }
        }
    }
}
