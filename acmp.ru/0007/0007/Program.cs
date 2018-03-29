using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestPileOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] pileOfCoins = new int[3];
            Console.WriteLine("Три кучки монет:");
            for (int i = 0; i < pileOfCoins.Length; i++)
            {
                pileOfCoins[i] = rnd.Next(1, 1000000000);
                Console.Write(pileOfCoins[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Вождь должен взять кучку из {0} камней", GenPileOfMaxCoins(pileOfCoins));
        }
        static int GenPileOfMaxCoins (int [] pileOfCoins)
        {
            return pileOfCoins.Max();
        }
    }
}
