using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicity
{
    class Set<T>
    {
        public IEnumerable<T> Items { get; set; }

        public Set(IEnumerable<T> mas)
        {
            Items = mas;
        }

        internal void AddElement(T element)
        {
            if (!Items.Contains(element))
            {
                var tempList = new List<T>(Items);
                tempList.Add(element);
                Items = tempList;
            }
            else
            {
                Console.WriteLine($"Элемент {element} уже содержится во множестве.");
            }
        }

        internal void DeleteElement(T element)
        {
            if (!Items.Contains(element))
            {
                Console.WriteLine($"Элемент {element} не найден в множестве.");
            }
            else
            {
                var tempList = new List<T>(Items);
                tempList.Remove(element);
                Items = tempList;
            }            
        }

        internal Set<T> Intersect (Set<T> source)
        {
            return new Set<T> (Items.Intersect(source.Items));
        }

        internal Set<T> Difference (Set<T> source)
        {
            return new Set<T>(Items.Except(source.Items));
        }

        internal void PrintSet (Set<int> source)
        {
            foreach (T m in Items)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
        }
    }
}
