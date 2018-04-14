using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorArray
{
    class Vectors
    {
        private int [] _array;

        public int[] Array { get; set; }

        internal Vectors (int [] array)
        {
            Array = array;
        }

        internal void PrintArray ()
        {
            Console.WriteLine("Все элементы массива:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ", ");
            }
            Console.WriteLine();
        }

        internal int GetArrayElement(int n)
        {
            return Array[n - 1];
        }

        internal void PrintArrayElement(int n)
        {
            Console.WriteLine($"Элемент {n} = {Array[n - 1]}");
        }

        internal int [] GetDifferenceArrayScalar (int n)
        {
            int[] differenceArray = new int[Array.Length];
            for (int i = 0; i < differenceArray.Length; i++)
            {
                differenceArray[i] = Array[i] - n;
            }
            return differenceArray;
        }

        internal int[] GetAdditionArrayScalar(int n)
        {
            int[] differenceArray = new int[Array.Length];
            for (int i = 0; i < differenceArray.Length; i++)
            {
                differenceArray[i] = Array[i] + n;
            }
            return differenceArray;
        }

    }
}
