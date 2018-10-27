using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реализация алгоритма сортировки пузырьком

namespace SortingBubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 101);
            List<int> numbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                numbers.Add(rnd.Next(-100, 101));
            }
            Console.WriteLine("Список длиной {0} до сортировки:", length);
            foreach (int m in numbers)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            BubbleSort(numbers);
        }

        static void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - (i + 1); j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Список длиной {0} после сортировки простыми обменами или пузырьком:", numbers.Count);
            foreach (int m in numbers)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
        }
    }
}
