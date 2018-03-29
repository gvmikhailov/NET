using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/12/2013_05_19_operator_cikla_foreach_v_si-sharp.html

namespace CycleForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arraySize = rnd.Next(1, 101);
            int[] numbers = new int[arraySize];
            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 101);
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Вывод элементов массива в промежутке от 21 до 49:");
            foreach (int m in numbers)
            {
                if (m > 20 && m <50)
                {
                    Console.Write(m + ", ");
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
        }
    }
}
