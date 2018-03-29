using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReloadMethods
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] intArray = new int[20];
            Console.WriteLine("Введите необходимый разделитель: (Enter для разделителя по умолчанию - запятая)");
            string delimeter = Console.ReadLine();
            if (delimeter == "")
            {
                SetDelimeter(intArray);
            }
        else
            {
                SetDelimeter(intArray, delimeter);
            }

        }
        public static void SetDelimeter (int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(0, 101);
                Console.Write(intArray[i] + ", ");
            }
        }
        public static void SetDelimeter(int[] intArray, string delimiter)
        {
            for (int j = 0; j < intArray.Length; j++)
            {
                intArray[j] = rnd.Next(0, 101);
                Console.Write(intArray[j] + delimiter + " ");
            }          
        }
    }
}
