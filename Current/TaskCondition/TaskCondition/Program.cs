using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1881

namespace TaskCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int strings = rnd.Next(1, 101);
            Console.WriteLine("Количество строк на странице - {0}", strings);
            int symbols = rnd.Next(1, 101);
            Console.WriteLine("Количество символов в строке - {0}", symbols);
            int words = rnd.Next(500, 10001);
            Console.WriteLine("Количество слов в тексте - {0}", words);
            string[] wordArray = { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin", "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch", "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            List<string> wordList = new List<string>();
            for (int i = 0; i < words; i++)
            {
                int mIndex = rnd.Next(0, wordArray.Length);
                wordList.Add(wordArray[mIndex]);
            }
            GetPageCount(words, symbols, strings, wordList);
        }
        static void GetPageCount (int words, int symbols, int strings, List<string> wordList)
        {
            int stringCounter = 0;
            int stringLenght = 0;
            for (int j = 0; j < words; j++)
            {
                stringLenght = stringLenght + 1 + wordList[j].Length;
                if (stringLenght >= symbols)
                {
                    stringCounter += 1;
                    j = j - 1;
                    stringLenght = 0;
                }
            }
            Console.WriteLine("Количество строк в описании - " + stringCounter);
            int pageCounter = 0;
            if (stringCounter % strings > 0)
            {
                pageCounter = (stringCounter / strings) + 1;
            }
            else
            {
                pageCounter = stringCounter / strings;
            }
            Console.WriteLine("Количество страниц в описании - " + pageCounter);
        }
    }
}
