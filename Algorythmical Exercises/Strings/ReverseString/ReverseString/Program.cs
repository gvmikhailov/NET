using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вводится строка, и программа ее переворачивает и распечатывает на экран.

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<char> alphabeth = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
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
            Console.WriteLine("Строка до переворота:");
            Console.WriteLine(wordString);
            Console.WriteLine();
            Console.WriteLine("Строка после переворота:");
            string reversedString = GetReverseString(wordString);
            Console.WriteLine(reversedString);
        }

        static string GetReverseString(string words)
        {
            List<char> listOfWords = words.ToList();            
            listOfWords.Reverse();
            string reversedString = string.Empty;
            foreach (char m in listOfWords)
            {
                reversedString += m;
            }
            Console.WriteLine();
            return reversedString;
        }
    }
}
