using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Посчитать число строк и слов в каждой строке. 

namespace WordAndStringCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<char> alphabeth = new List<char>(){'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                     'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };          
            int numberOfString = rnd.Next(2, 10);
            string wordString = string.Empty;
            for (int i = 0; i < numberOfString; i++)
            {
                int stringLength = rnd.Next(2, 7);
                for (int j = 0; j < stringLength; j++)
                {
                    int wordLength = rnd.Next(2, 21);
                    for (int k = 0; k < wordLength; k++)
                    {
                        wordString += alphabeth[rnd.Next(0, alphabeth.Count)];
                    }
                    if (j < wordLength - 1)
                    {
                        wordString += " ";
                    }
                }
                if (i < numberOfString - 1)
                {
                    wordString += "\n ";
                }
            }
            Console.WriteLine("Посчитаем количество строк и количество слов в каждой строке: \n {0}", wordString);
            GetStringAndWordCount(wordString);
        }

        static void GetStringAndWordCount(string wordString)
		{
            List<int> wordsCounter = new List<int>();
            List<string> wordsList = wordString.Split(' ').ToList();
            if (wordsList.Contains(""))
            {
                wordsList.RemoveAt(wordsList.IndexOf(""));
            }
			for (int i = 0; i<wordsList.Count; i++)
			{
				if (wordsList[i] == "\n")
				{
					wordsCounter.Add(i);
					for(int k = 0; k<=i; k++)
					{
						wordsList.RemoveAt(0);						
					}
                    i = -1;
                    continue;
                }
				else if (!wordsList.Contains("\n"))
				{
					wordsCounter.Add(wordsList.Count);
					break;
				}
				else
				{
					continue;
				}
			}
			int allWords = 0;
            Console.WriteLine("Количество строк - {0}", wordsCounter.Count);
			for (int j = 0; j<wordsCounter.Count; j++)
			{
				Console.WriteLine("Количество слов в строке {0} - {1}", j+1, wordsCounter[j]);
				allWords += wordsCounter[j];
			}
			Console.WriteLine("Всего количество слов - {0}", allWords);
			Console.WriteLine();
		}
    }
}
