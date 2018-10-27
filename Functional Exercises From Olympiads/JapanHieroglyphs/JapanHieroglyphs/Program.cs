using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1545

namespace JapanHieroglyphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfStrings = rnd.Next(1, 1001);
            var chars = "bcdfghjklmnpqrstvwxz";
            var chars2 = "aeiouy";
            var stringChars = new char[numberOfStrings];
            var stringChars2 = new char[numberOfStrings];
            List<string> latinList = new List<string>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                stringChars[i] = chars[rnd.Next(chars.Length)];
                stringChars2[i] = chars2[rnd.Next(chars2.Length)];
                latinList.Add(stringChars[i].ToString() + stringChars2[i].ToString());
            }
            for (int j = 0; j < numberOfStrings; j++)
            {
                Console.WriteLine(latinList[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Введите первый символ необходимого иероглифа: ");
            string coincidence = Console.ReadLine();
            Regex myCoincidence = new Regex($"^{coincidence}");
            for (int k = 0; k < numberOfStrings; k++)
            {
                MatchCollection matches = myCoincidence.Matches(latinList[k]);
                foreach (Match m in matches)
                {
                    Console.WriteLine(latinList[k]);
                }
            }
        }
    }
}
