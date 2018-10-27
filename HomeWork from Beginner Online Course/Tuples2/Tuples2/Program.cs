using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples2
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedList = new List<(int Index, string Name)>();
            unsortedList.Add((10, "Ten"));
            unsortedList.Add((9, "Nine"));
            unsortedList.Add((1, "One"));
            SortList(unsortedList);
        }
        static void SortList (List<(int Index, string Name)> unsortedlist)
        {
            var sortedList = from thing in unsortedlist orderby thing.Index select thing;
            foreach (var m in sortedList)
            {
                Console.WriteLine(m);
            }
        }
    }
}
