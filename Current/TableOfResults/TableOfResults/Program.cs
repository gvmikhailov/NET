using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1100

namespace TableOfResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int commandNumber = rnd.Next(1, 500);
            Console.WriteLine("Количество комманд - {0}", commandNumber);
            List<int[]> commandsData = new List<int[]>();           
            for (int i = 0; i < commandNumber; i++)
            {
                commandsData.Add(new int[] { i + 1, rnd.Next(0, commandNumber + commandNumber) });
            }
            GetSortedTableOfResult(commandsData);
        }
        static void GetSortedTableOfResult (List<int[]> commandsData)
        {
            var sortedList = commandsData.OrderBy(x => x[1]).ToList();
            foreach (int[] item in sortedList)
            {
                Console.WriteLine("Номер комманды: " + item[0] + ", количество задач: " + item[1]);
            }
            Console.WriteLine();
        }
    }
}
