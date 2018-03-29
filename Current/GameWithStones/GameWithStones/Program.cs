using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1180

namespace GameWithStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int winner;
            int minStoneQuantity;
            Random rnd = new Random();
            int quantity = rnd.Next(0, 1000);
            string stoneQuantity = quantity.ToString();
            Console.WriteLine("Число камней - " + stoneQuantity);
            WinnerDetermainer(stoneQuantity, out winner, out minStoneQuantity);
            Console.WriteLine("Выиграл {0} Никифор", winner);
            if (winner == 1)
            {
                Console.WriteLine("Первый Никифор первым ходом взял {0} камней", minStoneQuantity);
            }
        }
        static void WinnerDetermainer (string stoneQuantity, out int winner, out int minStoneQuantity)
        {
            minStoneQuantity = 0;
            char[] digits = stoneQuantity.ToCharArray();
            int summOfDigits = 0; 
            for (int i = 0; i < stoneQuantity.Length; i++)
            {
                summOfDigits += digits[i] - '0';
            }
            if (summOfDigits % 3 == 0 )
            {
                winner = 2;
            }
            else
            {
                winner = 1;
                minStoneQuantity = summOfDigits % 3;
            }
        }
    }
}
