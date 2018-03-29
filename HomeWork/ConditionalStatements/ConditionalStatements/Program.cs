using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/9/2013_04_17_uslovnye_operatory_v_si-sharp_ternarnyj_operator.html

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guests = rnd.Next(0, 6);
            int hosts = rnd.Next(0, 6);
            Console.WriteLine("Счет игры - Гости {0} : {1} Хозяева", guests, hosts);
            Console.WriteLine(GetResultOfMatch(guests, hosts));
        }
        static string GetResultOfMatch (int guests, int hosts)
        {
            string resultOfMatch = string.Empty;
            if (guests > hosts)
            {
                resultOfMatch = "Победили Гости";
            }
            else if (hosts > guests)
            {
                resultOfMatch = "Победили Хозяева";
            }
            else
            {
                resultOfMatch = "Ничья";
            }
            return resultOfMatch;
        }
    }
}
