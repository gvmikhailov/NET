using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int listLength = rnd.Next(10, 31);
            Console.WriteLine("Элементов в последовательности: {0}", listLength);
            int n = rnd.Next(1, 6);
            Console.WriteLine("Количество последних элементов, которые необходимо удалить из последовательности: {0}", n);
            for (int i = 0; i < listLength; i++)
            {
                ListToDist<int>.Add(rnd.Next(1, 51));
            }
            ListToDist<int>.Print();
            Console.WriteLine();
            ListToDist<int>.FilterLast<int>(ListToDist<int>.source, n);
            Console.WriteLine();
        }
    }
}
