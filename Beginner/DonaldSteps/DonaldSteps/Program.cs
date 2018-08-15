using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=2023

namespace DonaldSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] disneyCartoonsHeroes = { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin", "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch", "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            string[] disneyCartoonsHeroes1 = { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin" };
            string[] disneyCartoonsHeroes2 = { "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch" };
            string[] disneyCartoonsHeroes3 = { "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            Random rnd = new Random();
            int lettersCounter = rnd.Next(10, 101);
            string[] numberOfLetters = new string[lettersCounter];
            for (int i = 0; i < numberOfLetters.Length; i++)
            {
                int mIndex = rnd.Next(0, disneyCartoonsHeroes.Length);
                numberOfLetters[i] = disneyCartoonsHeroes[mIndex];
                Console.Write(numberOfLetters[i] + ", ");
            }
            Console.WriteLine();
            int steps = GetSteps(numberOfLetters, disneyCartoonsHeroes1, disneyCartoonsHeroes2, disneyCartoonsHeroes3);
            Console.WriteLine($"Чтобы разнести все письма, Дональду необходимо сделать {steps} шагов");
        }
        static int GetSteps(string[] numberOfLetters, string[] disneyCartoonsHeroes1, string[] disneyCartoonsHeroes2, string[] disneyCartoonsHeroes3)
        {
            int steps = 0;
            int counter = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < numberOfLetters.Length - 1; j++)
                {
                    if (((numberOfLetters[j] == disneyCartoonsHeroes1[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes1[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes3[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes3[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes2[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes2[i])))
                    {
                        counter = 0;
                    }
                    else if (((numberOfLetters[j] == disneyCartoonsHeroes2[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes3[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes1[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes2[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes3[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes2[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes2[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes1[i])))
                    {
                        counter = 1;
                    }
                    else if (((numberOfLetters[j] == disneyCartoonsHeroes1[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes3[i])) || ((numberOfLetters[j] == disneyCartoonsHeroes3[i]) && (numberOfLetters[j + 1] == disneyCartoonsHeroes1[i])))
                    {
                        counter = 2;
                    }                    
                }
                steps += counter;
            }
            return steps;
        }
    }
}
