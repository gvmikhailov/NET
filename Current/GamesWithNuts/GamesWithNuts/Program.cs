using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWithNuts
{
    class Program
    {
        // ответ есть в обсуждении на форуме
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int pileCount = Generator(10);
            Console.WriteLine("Задано {0} кучек", pileCount);
            int[] nutsCount = new int[pileCount];
            for (int k = 1; k <= pileCount; k++)
            {
                nutsCount[k-1] = Generator(26);
                Console.WriteLine("в {0} кучке {1} орехов", k, nutsCount[k-1]);
            }
        }
        static int Generator(int lenght)
        {  
            int number = 0;
            for (int i = 0; i < 100; i++)
            {
                int betweenNumber = rnd.Next(5, lenght);
                if (betweenNumber % 2 == 0)
                {
                    continue;
                }
                else
                {
                    number = betweenNumber;
                }
            }
            return number;
        }
        static string Winner (int nutsCount, string betweenWinner)
        {
            string winner = betweenWinner;
            return winner;
        }
    }
}
