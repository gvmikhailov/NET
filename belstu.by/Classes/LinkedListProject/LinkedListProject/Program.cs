using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        internal static Random rnd = new Random();

        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            LinkedListNode<int> node = new LinkedListNode<int>(5);
            numbers.AddLast(node);
            int numbersCount = rnd.Next(1, 21);
            Console.WriteLine("Напечатаем двухсвязный список из {0} элементов:", numbersCount + 1);
            for (int i = 0; i < numbersCount; i++)
            {
                if (i%2 == 0)
                {
                    numbers.AddLast(rnd.Next(0, 51));
                }
                else
                {
                    numbers.AddFirst(rnd.Next(0, 51));
                }                
            }
            foreach(int n in numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();

            LList list1 = new LList(numbers, node);
            list1.AddElement();
            list1.PrintStrightElements();
            list1.DeleteElement();
            list1.PrintStrightElements();
            list1.PrintBackElements();

            int index = rnd.Next(1, list1.List.Count + 1);
            int element = list1.GetElementByIndex(index);
            Console.WriteLine("Элемент {0} в списке - {1}", index, element);
        }
    }
}
