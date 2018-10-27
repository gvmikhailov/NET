using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реализация алгоритма сортировки слиянием

namespace SortingMerge
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
            List<int> sortList = MergeSort(numbers);
            Console.WriteLine("Список длиной {0} после сортировки слиянием:", numbers.Count);
            foreach (int m in sortList)
            {
                Console.Write(m + ", ");
            }
        }

        static List<int> MergeSort(List<int> numbers)
        {
            if (numbers.Count == 1)
                return numbers;
            int middlePoint = numbers.Count / 2;
            return Merge(MergeSort(numbers.Take(middlePoint).ToList()), MergeSort(numbers.Skip(middlePoint).ToList()));
        }

        static List<int> Merge(List<int> listLeft, List<int> listRight)
        {
            int left = 0; 
            int right = 0;
            List<int> merged = new List<int>();
            for (int k = 0; k < listLeft.Count + listRight.Count; k++)
            {
                merged.Add(0);
            }
            for (int i = 0; i < listLeft.Count + listRight.Count; i++)
            {
                if (right < listRight.Count && left < listLeft.Count)
                {
                    if (listLeft[left] > listRight[right])
                    {
                        merged[i] = listRight[right++];
                    }
                    else
                    {  
                        merged[i] = listLeft[left++];
                    }
                }
                else
                { 
                    if (right < listRight.Count)
                    { 
                        merged[i] = listRight[right++];
                    }
                    else
                    { 
                    merged[i] = listLeft[left++];
                    }
                }
            }
            return merged;
        }
    }
}
