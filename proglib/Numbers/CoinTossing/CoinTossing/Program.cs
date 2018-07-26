using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Программа, которая симулирует подбрасывание одной монеты столько раз, сколько захочет пользователь. 
// Программа должна записывать результаты и подсчитывать сколько раз выпали орел и решка.

namespace CoinTossing
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int count = rnd.Next(1, 1000);
            GetCoinSide(count);
        }

        static void GetCoinSide(int count)
        {
            int eagles = 0;
            int tails = 0;
            for (int i = 0; i < count; i++)
            {
                int side = rnd.Next(0, 2);
                if (side == 0)
                {
                    eagles += 1;
                }
                else
                {
                    tails += 1;
                }
            }
            string countTimes = GetTimes(count);
            string tailsTimes = GetTimes(tails);
            string eaglesTimes = GetTimes(eagles);
            Console.WriteLine("Монетку подбросили {0} {1}", count, countTimes);
            Console.WriteLine("Решка выпала {0} {1}, Орел выпал {2} {3}", tails, tailsTimes, eagles, eaglesTimes);
        }

        static string GetTimes(int number)
        {
            string times = "раз";
            string twoTreeFour = number.ToString();
            string twoTreeFourSubs = twoTreeFour.Substring(twoTreeFour.Length - 1);
            int twoTreeFourInt = Convert.ToInt32(twoTreeFourSubs, 10);
            if (number%10 == 0)
            {
                return times;
            }
            else if (twoTreeFourInt == 2 || twoTreeFourInt == 3 || twoTreeFourInt == 4)
            {
                times = "раза";
                return times;
            }
            else
            {
                return times;
            }
        }
    }
}
