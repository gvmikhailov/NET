using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int srcArraySize = rnd.Next(10, 31);
            int[] src = new int[srcArraySize];
            Console.WriteLine("Создан массив из {0} элементов:",srcArraySize);
            for (int i = 0; i < src.Length; i++)
            {
                src[i] = rnd.Next(1, 10);
                Console.Write(src[i] + ", ");
            }
            Console.WriteLine();
            int[] arrayDistinct = Distinct(src);
            Console.WriteLine("Массив без дубликатов:");
            foreach (int m in arrayDistinct)
            {
                Console.Write(m + ", ");
            }
        }
        static int[] Distinct (int [] src)
        {
            int[] arrayDistinct = src.Distinct().ToArray();
            return arrayDistinct;
        }
    }
}
