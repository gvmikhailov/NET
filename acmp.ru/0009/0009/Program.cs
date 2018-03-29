using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetyasHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int summOfPositiveElements;
            long compositionBetweenMinandMax;
            int arrayLenght = rnd.Next(1, 51);
            int [] array = new int[arrayLenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
            }
            array = array.Distinct().ToArray();
            Console.WriteLine("Элементы массива:");
            foreach (int m in array)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            GetSummOfPositiveElementsAndCompositionBetweenMinandMax(array, out summOfPositiveElements, out compositionBetweenMinandMax);
            Console.WriteLine("Сумма положительных элементов массива - {0}", summOfPositiveElements);
            Console.WriteLine("Произведение элементов массива между минимальным и максимальным элементом - {0}", compositionBetweenMinandMax);
        }
        static void GetSummOfPositiveElementsAndCompositionBetweenMinandMax(int [] array, out int summOfPositiveElements, out long compositionBetweenMinandMax)
        {
            summOfPositiveElements = 0;
            compositionBetweenMinandMax = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summOfPositiveElements += array[i];
                }
                else
                {
                    continue;
                }
            }
            int indexMax = Array.IndexOf(array, array.Max());
            Console.WriteLine("Индекс максимального элемента - {0}", indexMax);
            int indexMin = Array.IndexOf(array, array.Min());
            Console.WriteLine("Индекс минимального элемента - {0}", indexMin);
            int firstIterationNumber = indexMax > indexMin ? indexMin : indexMax;
            int secondIterationNumber = indexMax > indexMin ? indexMax : indexMin;
            for (int i = firstIterationNumber + 1; i < secondIterationNumber; i++)
            {
                compositionBetweenMinandMax *= array[i];
            }
        }
    }
}
