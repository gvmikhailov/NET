using System;
using System.Linq;

namespace Cubic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array1 = new int[rnd.Next(1, 11)];
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 101);
                array2[i] = rnd.Next(1, 101);
            }
            CompareArray(array1, array2);
        }
        static void CompareArray (int[] array1, int []array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            if (array1.SequenceEqual(array2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
