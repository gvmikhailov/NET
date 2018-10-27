using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lengthMassive1 = rnd.Next(10, 20);
            int lengthMassive2 = rnd.Next(10, 20);
            Console.WriteLine("В коллекции 1 {0} элементов, в коллекции 2 {1} элементов", lengthMassive1, lengthMassive2);
            List <int> massive1 = new List<int>(lengthMassive1);
            List<int> massive2 = new List<int>(lengthMassive2);            
            for (int i = 0; i < lengthMassive1; i++)
            {
                massive1.Add(rnd.Next(0, 101));                
            }
                        
            for (int j = 0; j < lengthMassive2; j++)
            {
                massive2.Add(rnd.Next(0, 101));
            }
            massive1 = massive1.Distinct().ToList();
            massive2 = massive2.Distinct().ToList();
            Console.WriteLine("Первое множество:");
            foreach (var m in massive1)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Второе множество:");
            foreach (var m in massive2)
            {
                Console.Write(m + ", ");
            }
            Console.WriteLine();
            Set<int> multitude1 = new Set<int>(massive1);
            Set<int> multitude2 = new Set<int>(massive2);
            int newElementMassive1 = rnd.Next(0, 101);
            Console.WriteLine("Добавим элемент в коллекцию 1 - {0}", newElementMassive1);
            multitude1.AddElement(newElementMassive1);
            Console.WriteLine("Множество 1 после добавления элемента:");
            multitude1.PrintSet(multitude1);
            int newElementMassive2 = rnd.Next(0, 101);
            Console.WriteLine("Добавим элемент в коллекцию 2 - {0}", newElementMassive2);
            multitude2.AddElement(newElementMassive2);
            Console.WriteLine("Множество 2 после добавления элемента:");
            multitude2.PrintSet(multitude2);
            int deleteElementMassive1 = rnd.Next(0, 101);
            Console.WriteLine("Удалим элемент из коллекции 1 - {0}", deleteElementMassive1);
            multitude1.DeleteElement(deleteElementMassive1);
            Console.WriteLine("Множество 1 после удаления элемента:");
            multitude1.PrintSet(multitude1);
            int deleteElementMassive2 = rnd.Next(0, 101);
            Console.WriteLine("Удалим элемент из коллекции 2 - {0}", deleteElementMassive2);
            multitude2.DeleteElement(deleteElementMassive2);
            Console.WriteLine("Множество 2 после удаления элемента:");
            multitude2.PrintSet(multitude2);
            Set<int> differrenceMultitudes = multitude1.Difference(multitude2);
            Console.WriteLine("Разность множеств:");
            differrenceMultitudes.PrintSet(differrenceMultitudes);
            Set<int> intersectMultitudes = multitude1.Intersect(multitude2);
            Console.WriteLine("Пересечение множеств:");
            intersectMultitudes.PrintSet(intersectMultitudes);
        }
    }
}
