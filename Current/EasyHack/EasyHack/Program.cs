using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1404

namespace EasyHack
{
    partial class Program
    {
        static char[] alphabeth = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static void Main(string[] args)
        {
            string word = string.Empty;
            Console.WriteLine("Генерируем слово...");
            Random rnd = new Random();
            int lengthOfString = rnd.Next(0, 101);
            string decodeWord = string.Empty;
            for (int i = 0; i < lengthOfString; i++)
            {
                decodeWord += alphabeth[rnd.Next(alphabeth.Length)];
            }
            Console.WriteLine(decodeWord);
            Console.WriteLine("Раскодируем наше слово...");
            Console.WriteLine(Decryption(decodeWord, out word));
            Console.WriteLine("Раскодируем обратно для проверки...");
            Console.WriteLine(Encryption(word));
        }
    }
}
