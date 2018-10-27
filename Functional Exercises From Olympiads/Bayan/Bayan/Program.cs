using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1563

namespace Bayan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfShops = rnd.Next(1, 1001);            
            string[] shopTitle = { "shop1", "shop2", "shop3", "shop4", "shop5", "shop6", "shop7", "shop8", "shop9", "shop10", "shop11", "shop12", "shop13", "shop14", "shop15", "shop16", "shop17", "shop18", "shop19", "shop20", "shop21", "shop22", "shop23", "shop24", "shop25", "shop26", "shop27", "shop28", "shop29", "shop30", "shop31" };
            List<string> shopList = new List<string>();
            for (int i = 0; i < numberOfShops; i++)
            {
                int mIndex = rnd.Next(0, shopTitle.Length);
                shopList.Add(shopTitle[mIndex]);
                Console.Write(shopList[i] + "; ");
            }
            Console.WriteLine();
            TakeShops(shopList, numberOfShops);
        }
        static void TakeShops(List<string> shopList, int numberOfShops)
        {
            List<string>iteration = shopList.Distinct().ToList<string>();
            int count = iteration.Count();
            int bayans = numberOfShops - count;
            Console.WriteLine($"Анжела сказала БАЯН {bayans} раз");
        }
    }
}
