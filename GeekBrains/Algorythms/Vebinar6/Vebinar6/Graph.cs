using System;
using System.Collections.Generic;
using System.Linq;

namespace Vebinar6
{
    class Graph
    {
        public Dictionary<int, HashSet<int>> Nodes { get; set; }

        public Graph()
        {
            Nodes = new Dictionary<int, HashSet<int>>();
        }

        public void AddToEnd(int source, int target)
        {
            if (Nodes.ContainsKey(source))
            {
                try
                {
                    Nodes[source].Add(target);
                }
                catch
                {
                    Console.WriteLine("Данный путь уже существует: " + source + " к " + target);
                }
            }
            else
            {
                var hs = new HashSet<int>();
                hs.Add(target);
                Nodes.Add(source, hs);
            }
        }

        public int? BFSFind(int element)
        {
            int start = 1; // идем всегда от первой ноды
            HashSet<int> visited = new HashSet<int>();
            visited.Add(start);
            Queue<int> find = new Queue<int>();
            find.Enqueue(start); 

            while (find.Count > 0)
            {
                int current = find.Dequeue();
                Console.Write($"Берем ноду со значением {current} - ");
                if (current == element)
                {
                    Console.WriteLine("И это она!");
                    return visited.Count();
                }
                else
                {
                    Console.WriteLine("И это не она");
                }

                if (Nodes.ContainsKey(current))
                {
                    foreach (int neighbour in Nodes[current].Where(a => !visited.Contains(a)))
                    {
                        visited.Add(neighbour);
                        find.Enqueue(neighbour);
                    }
                }
            }
            Console.WriteLine("Нода с таким значением не найдена!");
            return null;
        }

        public int? DFSFind(int element)
        {
            int start = 1; // идем всегда от первой ноды
            HashSet<int> visited = new HashSet<int>();
            visited.Add(start);
            Stack<int> find = new Stack<int>();
            find.Push(start);

            while (find.Count > 0)
            {
                int current = find.Pop();
                Console.Write($"Берем ноду со значением {current} - ");
                if (current == element)
                {
                    Console.WriteLine("И это она!");
                    return visited.Count();
                }
                else
                {
                    Console.WriteLine("И это не она");
                }

                if (Nodes.ContainsKey(current))
                {
                    foreach (int neighbour in Nodes[current].Where(a => !visited.Contains(a)))
                    {
                        visited.Add(neighbour);
                        find.Push(neighbour);
                    }
                }
            }
            Console.WriteLine("Нода с таким значением не найдена!");
            return null;
        }

    }
}
