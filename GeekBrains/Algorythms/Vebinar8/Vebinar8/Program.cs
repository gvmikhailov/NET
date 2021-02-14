using System;

namespace Vebinar8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(50, 101);
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rnd.Next(-100, 101);
            }
            Console.WriteLine("Список длиной {0} до сортировки:", length);
            foreach (int m in numbers)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            Heep.BucketSort(numbers);
            Console.WriteLine("Список длиной {0} после Bucket сортировки слиянием:", numbers.Length);
            foreach (int m in numbers)
            {
                Console.Write(m + ", ");
            }
            Console.ReadKey();
        }
    }
}
