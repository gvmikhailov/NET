using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1567

namespace SMSSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            string tagline = "a vas, ya poproshu ostatsya!";
            var symbols = tagline.ToArray();
            int roublesSumm = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i].ToString() == "a" || symbols[i].ToString() == "d" || symbols[i].ToString() == "g" || symbols[i].ToString() == "j" || symbols[i].ToString() == "m" || symbols[i].ToString() == "p" || symbols[i].ToString() == "s" || symbols[i].ToString() == "v" || symbols[i].ToString() == "y" || symbols[i].ToString() == " " || symbols[i].ToString() == ".")
                {
                    roublesSumm += 1;
                }
                else if (symbols[i].ToString() == "b" || symbols[i].ToString() == "e" || symbols[i].ToString() == "h" || symbols[i].ToString() == "k" || symbols[i].ToString() == "n" || symbols[i].ToString() == "q" || symbols[i].ToString() == "t" || symbols[i].ToString() == "w" || symbols[i].ToString() == "z" || symbols[i].ToString() == ",")
                {
                    roublesSumm += 2;
                }
                else
                {
                    roublesSumm += 3;
                }
            }
            Console.WriteLine("За спам должны заплатить - " + roublesSumm + " рубля");
        }
    }
}
