using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLast2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string stringVariable = string.Empty;
            int variableType = rnd.Next(1, 4); // 1 - int; 2 - string; 3 - SomeClass
            List<string> strings = new List<string> { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            IEnumerable<string> stringVariables = new[] { strings[rnd.Next(0, strings.Count)] };
            IEnumerable<int> intVariables = new[] { rnd.Next(0, 101) };
            IEnumerable<SomeClass> someClassVariables = new[] { new SomeClass(rnd.Next(0, 101), strings[rnd.Next(0, strings.Count)]) };
            int length = rnd.Next(1, 101);
            int n = rnd.Next(1, length);
            Console.WriteLine("Задана последовательность длиной {0} из которой необходимо удалить элементов - {1}", length, n);            
            
            if (variableType == 1)
            {
                for (int i = 0; i < length -1; i++)
                {
                    intVariables = intVariables.Concat(new[] { rnd.Next(0, 101) });
                }
                Console.WriteLine("Изначальная последовательность:");
                TClass<int>.Print(intVariables);
                Console.WriteLine();
                IEnumerable<int> output = TClass<int>.FilterLast(intVariables, n);
                Console.WriteLine("Последовательность после удаления {0} элементов:", n);
                TClass<int>.Print(output);
            }
            else if (variableType == 2)
            {
                for (int i = 0; i < length -1; i++)
                {
                    stringVariables = stringVariables.Concat(new[] { strings[rnd.Next(0, strings.Count)] });
                }
                Console.WriteLine("Изначальная последовательность:");
                TClass<string>.Print(stringVariables);
                IEnumerable<string> output = TClass<string>.FilterLast(stringVariables, n);
                Console.WriteLine("Последовательность после удаления {0} элементов:", n);
                TClass<string>.Print(output);
            }
            else
            {
                for (int i = 0; i < length -1; i++)
                {
                    someClassVariables = someClassVariables.Concat(new[] { new SomeClass(rnd.Next(0, 101), strings[rnd.Next(0, strings.Count)]) });
                }
                Console.WriteLine("Изначальная последовательность:");
                TClass<SomeClass>.Print(someClassVariables);
                IEnumerable<SomeClass> output = TClass<SomeClass>.FilterLast(someClassVariables, n);
                Console.WriteLine("Последовательность после удаления {0} элементов:", n);
                TClass<SomeClass>.Print(output);
            }
        }
    }
}
