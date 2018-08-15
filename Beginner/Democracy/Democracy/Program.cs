using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1025

namespace Democracy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int groups = 0;
            int arraySize = rnd.Next(1, 102);
            if (arraySize%2 == 0)
            {
                groups = arraySize + 1;
            }
            else
            {
                groups = arraySize;
            }
            Console.WriteLine("Количество групп избирателей - {0}", groups);
            int[] groupMembers = new int[groups];
            Console.WriteLine("Количество избирателей по группам:");
            for (int i = 0; i < groupMembers.Length; i++)
            {
                int groupOfCitizen = 0;
                int tempCitizen = rnd.Next(1, 10000);
                if (tempCitizen % 2 == 0)
                {
                    groupOfCitizen = tempCitizen + 1;
                }
                else
                {
                    groupOfCitizen = tempCitizen;
                }
                groupMembers[i] = groupOfCitizen;
                Console.Write(groupMembers[i] + "; ");
            }           
            Console.WriteLine();
            Array.Sort(groupMembers);
            GetMaxSupporter(groupMembers);
        }
        static void GetMaxSupporter(int[] groupMembers)
        {
            int summOfSitizens = 0;
            for (int i = 0; i < (groupMembers.Length + 1) / 2; i++)
            {
                groupMembers[i] = (groupMembers[i] + 1) / 2;
                summOfSitizens += groupMembers[i];                
            }
            Console.WriteLine("Минимальное количество сторонников партии, способное решить исход голосования - " + summOfSitizens);
        }
    }
}
