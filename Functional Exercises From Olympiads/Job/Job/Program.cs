using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1785

namespace Localization
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int quantity = rnd.Next(1, 2001);
            Console.WriteLine("Количество монстров: {0}", quantity);           
            Console.WriteLine(Translate(quantity));
        }

        static string Translate (int quantity)
        {
            string translate = string.Empty;
            if (quantity >= 1 && quantity <=4)
            {
                translate = "несколько";
            }
            if (quantity >= 5 && quantity <= 9)
            {
                translate = "немного";
            }
            if (quantity >= 10 && quantity <= 19)
            {
                translate = "отряд";
            }
            if (quantity >= 20 && quantity <= 49)
            {
                translate = "толпа";
            }
            if (quantity >= 50 && quantity <= 99)
            {
                translate = "орда";
            }
            if (quantity >= 100 && quantity <= 249)
            {
                translate = "множество";
            }
            if (quantity >= 250 && quantity <= 499)
            {
                translate = "сонмище";
            }
            if (quantity >= 500 && quantity <= 999)
            {
                translate = "полчище";
            }
            if (quantity >= 1000 && quantity <= 2000)
            {
                translate = "легион";
            }
            return translate;
        }
    }
}
