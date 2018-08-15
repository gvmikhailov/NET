using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1496

namespace Spamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int submits = rnd.Next(50, 101);
            Console.WriteLine("Количество сабмитов за последние 10 минут - {0}", submits);
            string[] commands = { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin", "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch", "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            List<string> submitCommands = new List<string>();
            for (int i = 0; i < submits; i++)
            {
                int mIndex = rnd.Next(0, commands.Length);
                submitCommands.Add(commands[mIndex]);
                Console.WriteLine(submitCommands[i]);
            }
            Console.WriteLine();
            PrintSpamers(submitCommands);
        }
        static void PrintSpamers (List<string> submitCommands)
        {
            List<string> spamerCommands = submitCommands.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            Console.WriteLine("Комманды спамеры:");
            foreach (string m in spamerCommands)
            {
                Console.WriteLine(m);
            }
        }
    }
}
