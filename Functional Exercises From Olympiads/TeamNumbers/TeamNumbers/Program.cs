using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1880

namespace TeamNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght1 = rnd.Next(1, 4001);
            Console.WriteLine("Количество чисел первого игрока: {0}", lenght1);
            int lenght2 = rnd.Next(1, 4001);
            Console.WriteLine("Количество чисел второго игрока: {0}", lenght2);
            int lenght3 = rnd.Next(1, 4001);
            Console.WriteLine("Количество чисел третьего игрока: {0}", lenght3);
            int[] numbersOfFirstGamer = new int[lenght1];
            int[] numbersOfSecondGamer = new int[lenght2];
            int[] numbersOfThirdGamer = new int[lenght3];
            for (int i = 0; i < numbersOfFirstGamer.Length; i++)
            {
                numbersOfFirstGamer[i] = rnd.Next(0, 10001);
                Console.Write(numbersOfFirstGamer[i] + ", ");
            }
            Console.WriteLine();
            for (int j = 0; j < numbersOfSecondGamer.Length; j++)
            {
                numbersOfSecondGamer[j] = rnd.Next(0, 10001);
                Console.Write(numbersOfSecondGamer[j] + ", ");
            }
            Console.WriteLine();
            for (int k = 0; k < numbersOfThirdGamer.Length; k++)
            {
                numbersOfThirdGamer[k] = rnd.Next(0, 10001);
                Console.Write(numbersOfThirdGamer[k] + ", ");
            }
            Console.WriteLine();
            GetOwnTeamNumbers(numbersOfFirstGamer, numbersOfSecondGamer, numbersOfThirdGamer);
        }
        static void GetOwnTeamNumbers (int[] numbersOfFirstGamer, int[] numbersOfSecondGamer, int[] numbersOfThirdGamer)
        {
            List<int> numbersOfTeam = new List<int>();
            Array.Sort(numbersOfFirstGamer);
            Array.Sort(numbersOfSecondGamer);
            Array.Sort(numbersOfThirdGamer);
            for (int l = 0; l < numbersOfFirstGamer.Length; l++)
            {
                int index1 = System.Array.IndexOf(numbersOfSecondGamer, numbersOfFirstGamer[l]);
                int index2 = System.Array.IndexOf(numbersOfThirdGamer, numbersOfFirstGamer[l]);
                if (index1 >= 0 && index2 >= 0)
                {
                    numbersOfTeam.Add(numbersOfFirstGamer[l]);
                }
            }
            Console.WriteLine();
            List <int> numbersOfTeamEnd = numbersOfTeam.Distinct().ToList();
            Console.WriteLine("Собственные числа комманды: ");
            foreach (int m in numbersOfTeamEnd)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
        }
    }
}
