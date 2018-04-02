using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1654

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lengthOfString = rnd.Next(100, 200);
            var chars = "abcdefghijklmnopqrstuvwxyz";
            string stroka = string.Empty;            
            for (int i = 0; i < lengthOfString; i++)
            {
                stroka += chars[rnd.Next(chars.Length)];
            }
            Console.WriteLine("Зашифрованная строка: {0}", stroka);
            Console.WriteLine();
            Console.WriteLine("Рашифрованная строка: {0}",PrintDecryptionString(stroka));
        }
        static string PrintDecryptionString (string stroka)
        {
            string resultStroka = string.Empty;
            Regex myCoincidence = new Regex("(\\w)\\1");
            return resultStroka = myCoincidence.Replace(stroka, "");            
        }
    }
}
