using System;

namespace Vebinar6
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddToEnd(1, 2);
            graph.AddToEnd(1, 3);
            graph.AddToEnd(1, 4);
            graph.AddToEnd(2, 5);
            graph.AddToEnd(2, 6);
            graph.AddToEnd(4, 7);
            graph.AddToEnd(4, 8);
            graph.AddToEnd(5, 9);
            graph.AddToEnd(5, 10);
            graph.AddToEnd(7, 11);
            graph.AddToEnd(7, 12);

            int? bfs = graph.BFSFind(7);
            int? dfs = graph.DFSFind(4);

            Console.ReadKey();
        }
    }
}
