using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLast
{
    class ListToDist<T>
    {
        static List<T> list = new List<T>();
        public static void Add(T v)
        {
            list.Add(v);
        }
        public static IEnumerable<T> source = list;
        public static void Print()
        {
            Console.WriteLine("Изначальная последовательность:");
            foreach (T m in source)
            {
                Console.Write(m + ", ");
            }
        }
        public static IEnumerable<T> FilterLast<T> (IEnumerable<T> source, int n)
        {            
            IEnumerable<T> output = source.Reverse();
            output = output.Skip(n);
            output = output.Reverse();
            Console.WriteLine("Последовательность без {0} последних элементов:", n);
            foreach (T m in output)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            return output;
        }
    }
}
