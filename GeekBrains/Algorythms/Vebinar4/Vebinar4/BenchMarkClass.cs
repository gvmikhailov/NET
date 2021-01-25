using BenchmarkDotNet.Attributes;
using System;

namespace Vebinar4
{
    class BenchMarkClass
    {
        public static bool SearchInArray(string searchString)
        {
            //return Array.Exists(Program.listString, element => element == searchString); 

            //return Program.listString.Contains(searchString);

            for (int i = 0; i < Program.listString.Length; i++)
            {
                if (Program.listString[i] == searchString)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        public static bool SearchInHashSet(string searchString)
        {
            return Program.addingHashSet.Contains(searchString);
        }

        [Benchmark]
        public void SearchInArrayTest()
        {
            SearchInArray("ThisIsSearchFraze"); // Чтобы не нашел и пробежался по всем элеменам
        }

        [Benchmark]
        public void SearchInHashSetTest()
        {
            SearchInHashSet("ThisIsSearchFraze"); // Чтобы не нашел и пробежался по всем элеменам
        }
    }
}
