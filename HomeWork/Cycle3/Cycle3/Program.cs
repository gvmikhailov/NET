using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/11/2013_04_25_cikly_v_si-sharp_operatory_break_i_continue.html

namespace Cycle3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arraySize = rnd.Next(1, 100);
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array1[i] = rnd.Next(0, 101);
                array2[i] = rnd.Next(0, 101);
            }
            Console.WriteLine("Массив 1:");
            foreach (int m in array1)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив 2:");
            foreach (int n in array2)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив, образованный суммой i элементов массивов 1 и 2:");
            foreach (int k in GetSummOfTwoArray(array1,array2,arraySize))
            {
                Console.Write(k + ", ");
            }
            Console.WriteLine();
        }
        static int [] GetSummOfTwoArray (int [] array1, int [] array2, int arraySize)
        {
            int[] array3 = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
            return array3;
        }
    }
}
