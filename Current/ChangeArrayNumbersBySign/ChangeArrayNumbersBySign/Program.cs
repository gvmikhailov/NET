using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// изменение элементов массива на противоположные по знаку

namespace ChangeArrayNumbersBySign
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[rnd.Next(1, 100)];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-100,101);
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            numbers = ChangeArrayElemetsSign(numbers);
            foreach (int m in numbers)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
        }
        static int[] ChangeArrayElemetsSign(int[] numbers)
        {
            int[] changeSignNimbers = new int[numbers.Length];
            for (int k = 0; k < changeSignNimbers.Length; k++)
            {
                changeSignNimbers[k] = -numbers[k];
            }
            Console.WriteLine();
            return changeSignNimbers;
        } 
    }
}
