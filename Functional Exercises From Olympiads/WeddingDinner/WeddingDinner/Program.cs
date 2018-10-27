using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2100

namespace WeddingDinner
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guestNumber = rnd.Next(1, 21);
            Console.WriteLine("Введите количество друзей, которым отправлено приглашение: {0}", guestNumber);
            string[] guests = { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin", "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch", "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            string[] withFriend = { " ", "+one" };
            List<string> guestList = new List<string>();
            Regex r = new Regex($"[+]one");
            int guestCounter = 0;
            for (int i = 0; i < guestNumber; i++)
            {
                int fIndex = rnd.Next(0, withFriend.Length);
                guestList.Add(guests[i] + withFriend[fIndex]);
                Match m = r.Match(guestList[i]);
                if (m.Success)
                {
                    guestCounter += 2;
                }
                else
                {
                    guestCounter += 1;
                }
                Console.WriteLine(guestList[i]);
            }
            guestCounter = guestCounter + 2;
            if (guestCounter == 13)
            {
                guestCounter = guestCounter + 1;
            }
            Console.WriteLine("Всего гостей: " + guestCounter + " необходимо заплатить денег: " + guestCounter * 100 + "$");
        }
    }
}
