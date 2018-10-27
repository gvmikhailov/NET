using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1925

namespace BritishScientists
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ageOfNEX = rnd.Next(1, 101);
            Console.WriteLine("Сколько лет назад иноланетяне сбросили на Землю неведомое устройство - {0}", ageOfNEX);
            int kNumber = rnd.Next(1, 101);
            Console.WriteLine("Какое сегодня число неведомое устройство вывело на экран - {0}", kNumber);
            List<int[]> pairsOfNumbers = new List<int[]>();
            for (int i = 0; i < ageOfNEX; i++)
            {
                pairsOfNumbers.Add(new int[] { rnd.Next(0, 10), rnd.Next(0, 10) });
            }
            Console.WriteLine("Число, выведенное устройством, и число, предложенное ему на ввод, в i-м году:");
            foreach (int[] item in pairsOfNumbers)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
            Console.WriteLine();
            GetAnswerToBe(ageOfNEX, kNumber, pairsOfNumbers);
        }
        static void GetAnswerToBe(int ageOfNEX, int kNumber, List<int[]> pairsOfNumbers)
        {
            int summOfNEXNumbers = 0;
            int summOfHumanNumbers = 0;
            for (int k = 0; k < ageOfNEX; k++)
            {
                summOfNEXNumbers += pairsOfNumbers[k][0];
                summOfHumanNumbers += pairsOfNumbers[k][1];
            }
            summOfNEXNumbers = summOfNEXNumbers - (ageOfNEX + 1) * 2 + kNumber;
            int savingNumber = summOfNEXNumbers - summOfHumanNumbers;
            if (savingNumber > 0)
            {
                Console.WriteLine("Нужно ввести спасительное число - " + savingNumber);
            }
            else
            {
                Console.WriteLine("Big Bang!");
            }
        }
    }
}
