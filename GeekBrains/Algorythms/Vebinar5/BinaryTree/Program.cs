using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rList = new Random(47);

            int maxVal = 1000;
            int n = 20;

            List<int> list = new List<int>();
            list.Add(rList.Next(maxVal));
            BinaryTree tree = new BinaryTree(maxVal, null);
            tree.Root = tree;

            for (int i = 0; i < n; i++)
            {
                int val = rList.Next(maxVal);
                if (!list.Contains(val))
                {
                    list.Add(val);
                    tree.AddValue(val);
                }
            }

            BinaryTreePrinter.Print(tree.Root);

            tree.SearchByBFS(200);
            tree.SearchByDFS(200);

            Console.ReadKey();
        }
    }
}
