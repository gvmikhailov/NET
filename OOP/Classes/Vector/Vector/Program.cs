using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arraySize = rnd.Next(10, 50);
            int[] array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }
            Vectors array1 = new Vectors(array);
            array1.PrintArray();
            int element1 = rnd.Next(0, arraySize + 1);
            array1.PrintArrayElement(element1);
            int element2 = rnd.Next(0, arraySize + 1);
            Console.WriteLine("Элемент {0} масива - {1}", element2, array1.GetArrayElement(element2));
            int scalar1 = rnd.Next(1, 101);
            int[] arraySumScalar = array1.GetAdditionArrayScalar(scalar1);
            Console.WriteLine("Сумма элементов массива со скаляром {0}:", scalar1);
            foreach (int m in arraySumScalar)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            int scalar2 = rnd.Next(1, 101);
            int[] arrayDifScalar = array1.GetDifferenceArrayScalar(scalar2);
            Console.WriteLine("Разность элементов массива со скаляром {0}:", scalar2);
            foreach (int m in arrayDifScalar)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
        }
    }
}
