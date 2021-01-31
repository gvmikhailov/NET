using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class BinaryTree
    {
        public BinaryTree Parent { get; set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Root { get; set; }
        public int Value { get; set; }

        public BinaryTree(int val, BinaryTree parent)
        {
            Value = val;
            Parent = parent;
        }

        public void AddValue(int val)
        {
            if (val.CompareTo(Value) < 0)
            {
                if (Left == null)
                    Left = new BinaryTree(val, Left);
                else if (Left != null)
                    Left.AddValue(val);
            }
            else
            {
                if (Right == null)
                    Right = new BinaryTree(val, Right);
                else if (Right != null)
                    Right.AddValue(val);
            }
        }

        public BinaryTree SearchByBFS(int value)
        {
            Queue<BinaryTree> searchQueue = new Queue<BinaryTree>();
            BinaryTree current = Root;
            searchQueue.Enqueue(Root);

            while(searchQueue.Count != 0)
            {
                current = searchQueue.Dequeue();
                Console.WriteLine($"Берется элемент со значением {current.Value} и сравнивается с числом {value}");
                if (current.Value == value)
                {
                    Console.WriteLine("Это необходимый элемент дерева");
                    return current;
                }
                else
                {
                    if (current.Left != null)
                        searchQueue.Enqueue(current.Left);
                    if (current.Right != null)
                        searchQueue.Enqueue(current.Right);
                }
            }

            Console.WriteLine($"Элемент со значением {value} не найден в дереве!");
            return null;
        }

        public BinaryTree SearchByDFS(int value)
        {
            Stack<BinaryTree> searchStack = new Stack<BinaryTree>();
            BinaryTree current = Root;
            searchStack.Push(Root);

            while (searchStack.Count != 0)
            {
                current = searchStack.Pop();
                Console.WriteLine($"Берется элемент со значением {current.Value} и сравнивается с числом {value}");
                if (current.Value == value)
                {
                    Console.WriteLine("Это необходимый элемент дерева");
                    return current;
                }
                else
                {
                    if (current.Right != null)
                        searchStack.Push(current.Right);
                    if (current.Left != null)
                        searchStack.Push(current.Left);
                }
            }

            Console.WriteLine($"Элемент со значением {value} не найден в дереве!");
            return null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
