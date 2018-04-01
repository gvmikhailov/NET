using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1607

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int startPricePit = rnd.Next(100, 1001);
            Console.WriteLine("Стартовая цена Пети - {0}", startPricePit);
            int startPriceTaxidriver = rnd.Next(750, 2001);
            Console.WriteLine("Стартовая цена Таксиста - {0}", startPriceTaxidriver);
            int surchargePit = rnd.Next(50, 101);
            Console.WriteLine("Надбавка Пети - {0}", surchargePit);
            int discountTaxidriver = rnd.Next(50, 101);
            Console.WriteLine("Скидка Таксиста - {0}", discountTaxidriver);
            PrintPriceForTrip(startPricePit, startPriceTaxidriver, surchargePit, discountTaxidriver);
        }
        static void PrintPriceForTrip (int startPricePit, int startPriceTaxidriver, int surchargePit, int discountTaxidriver)
        {
            int pricePit = startPricePit;
            int priceTaxidriver = startPriceTaxidriver;
            int endPrice = 0;
            if (pricePit >= priceTaxidriver)
            {
                Console.WriteLine("Петя оказался дураком и едет за " + pricePit + " рублей");
            }
            else
            {
                for (int i = 0; i < 10000; i++)
                {
                    pricePit = pricePit + surchargePit;
                    priceTaxidriver = priceTaxidriver - discountTaxidriver;
                    if (priceTaxidriver > pricePit)
                    {
                        continue;
                    }
                    else
                    {
                        if (priceTaxidriver >= pricePit)
                        {
                            endPrice = priceTaxidriver;
                            break;
                        }
                        else
                        {
                            endPrice = pricePit;
                            break;
                        }
                    }
                }
                Console.WriteLine("Сговорились за {0} рублей", endPrice);
            }
        }
    }
}
