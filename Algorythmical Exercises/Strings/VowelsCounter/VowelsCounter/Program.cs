using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вводится строка, и программа считает количество гласных в тексте.

namespace VowelsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<char> alphabeth = new List<char>(){'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                     'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int wordLength = rnd.Next(2, 21);
            int stringlength = rnd.Next(5, 25);
            string wordString = string.Empty;
            for (int j = 0; j < wordLength; j++)
            {
                for (int i = 0; i < wordLength; i++)
                {
                    wordString += alphabeth[rnd.Next(0, alphabeth.Count)];
                }
                if (j < wordLength-1)
                {
                    wordString += " ";
                }
            }
            Console.WriteLine("Посчитаем гласные в строке - {0}", wordString);
            VowelsCount(wordString);
        }

        static void VowelsCount(string wordString)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            Dictionary<char, int> counter = new Dictionary<char, int>();
            string tempString = wordString.ToLower();
            int vowel = 0;
            for (int i = 0; i < vowels.Count; i++)
            {
                counter.Add(vowels[i], tempString.Count(count => count == vowels[i]));
            }
            foreach (var pairs in counter)
            {
                Console.WriteLine("Буква {0} в строке встретилась {1}{2}", pairs.Key, pairs.Value, GetTimes(pairs.Value));
            }
            foreach (var allVovels in counter)
            {
                vowel += allVovels.Value;
            }
            Console.WriteLine("Всего гласных букв в строке - {0}", vowel);
        }

        static string GetTimes(int number)
        {
            string times = "раз";
            string twoTreeFour = number.ToString();
            string twoTreeFourSubs = twoTreeFour.Substring(twoTreeFour.Length - 1);
            int twoTreeFourInt = Convert.ToInt32(twoTreeFourSubs, 10);
            if (number % 10 == 0)
            {
                return times;
            }
            else if (twoTreeFourInt == 2 || twoTreeFourInt == 3 || twoTreeFourInt == 4)
            {
                times = "раза";
                return times;
            }
            else
            {
                return times;
            }
        }
    }
}
