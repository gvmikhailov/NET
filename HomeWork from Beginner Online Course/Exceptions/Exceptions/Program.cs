using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {            
            int[] setOfNumbers = new int[10];
            Console.WriteLine("Заданный массив:");
            for (int i = 0; i < setOfNumbers.Length; i++)
            {
                setOfNumbers[i] = rnd.Next(1, 101);
                Console.Write(setOfNumbers[i] + ", ");
            }
            Console.WriteLine();
            GetSummOfTwoRandomArrayElements(setOfNumbers);
        }
        static void GetSummOfTwoRandomArrayElements (int [] setOfNumbers)
        {            
            try
            {
                int k = rnd.Next(0, 15);
                int l = rnd.Next(0, 15);
                Console.WriteLine("Сумма {0} и {1} элементов массива - {2}", k, l, setOfNumbers[k] + setOfNumbers[l]);
            }
            catch (Exception)
            {
                Console.WriteLine("Один из индексов выходит за границы массива");
            }
        }
    }
}
