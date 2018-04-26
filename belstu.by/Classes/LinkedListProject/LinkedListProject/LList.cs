using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class LList
    {
        public LinkedList<int> List { get; set; }
        public LinkedListNode<int> Node { get; set; }

        internal LList (LinkedList<int> list, LinkedListNode<int> node)
        {
            List = list;
            Node = node;
        }

        internal void AddElement()
        {
            List.AddAfter(Node, Program.rnd.Next(-10, 10));
        }

        internal void DeleteElement()
        {
            List.RemoveLast();
        }

        internal void PrintStrightElements()
        {
            foreach (int n in List)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
        }

        internal void PrintBackElements()
        {
            var newList = List.Reverse();
            foreach (int n in newList)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
        }

        internal int GetElementByIndex(int index)
        {
            int number = List.ElementAt(index - 1);
            return number;
        }
    }
}
