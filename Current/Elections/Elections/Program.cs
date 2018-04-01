using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1263

namespace Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numbersOfCandidates = rnd.Next(1, 5001);
            Console.WriteLine("Число кандидатов - {0}",numbersOfCandidates);
            int numbersOfVoters = rnd.Next(1, 10001);
            Console.WriteLine("Число избирателей - {0}", numbersOfCandidates);
            List<int> votes = new List<int>();
            for (int i = 0; i < numbersOfVoters; i++)
            {
                votes.Add(rnd.Next(1, numbersOfCandidates + 1));
                Console.Write(votes[i] + ", ");
            }
            Console.WriteLine();
            TakeResultOfVotes(numbersOfCandidates, numbersOfVoters, votes);
        }

        static void TakeResultOfVotes (int numbersOfCandidates, int numbersOfVoters, List<int> votes)
        {
            List<int> voiceCounter = new List<int>();
            for (int k = 1; k <= numbersOfCandidates; k++)
            {
                voiceCounter.Add(votes.Count(n => n.Equals(k)));
            }
            Console.WriteLine();
            for (int l = 0; l < numbersOfCandidates; l++)
            {
                double percentageVoiceCount = (Convert.ToDouble(voiceCounter[l]) / Convert.ToDouble(numbersOfVoters)) * 100;
                Console.WriteLine("За кандидата {0} проголосовали {1}% избирателей", l + 1, Math.Round(percentageVoiceCount, 2));
            }
        }
    }
}
