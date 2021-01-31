using System;

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
                {
                    Left = new BinaryTree(val, Left);
                }
                else if (Left != null)
                    Left.AddValue(val);
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinaryTree(val, Right);
                }
                else if (Right != null)
                    Right.AddValue(val);
            }
        }

        private BinaryTree SearchNext(BinaryTree tree, int val)
        {
            if (tree == null) return null;
            switch (val.CompareTo(tree.Value))
            {
                case 1: return SearchNext(tree.Right, val);
                case -1: return SearchNext(tree.Left, val);
                case 0: return tree;
                default: return null;
            }
        }

        public BinaryTree SearchByValue(int val)
        {
            return SearchNext(this, val);
        }

        public bool RemoveByValue(int val)
        {
            BinaryTree tree = SearchByValue(val);
            if (tree == null)
            {
                return false;
            }
            BinaryTree curTree;

            if (tree == this)
            {
                if (tree.Right != null)
                {
                    curTree = tree.Right;
                }
                else curTree = tree.Left;

                while (curTree.Left != null)
                {
                    curTree = curTree.Left;
                }
                int temp = curTree.Value;
                this.RemoveByValue(temp);
                tree.Value = temp;

                return true;
            }

            if (tree.Left == null && tree.Right == null && tree.Parent != null)
            {
                if (tree == tree.Parent.Left)
                    tree.Parent.Left = null;
                else
                {
                    tree.Parent.Right = null;
                }
                return true;
            }

            if (tree.Left != null && tree.Right == null)
            {
                tree.Left.Parent = tree.Parent;
                if (tree == tree.Parent.Left)
                {
                    tree.Parent.Left = tree.Left;
                }
                else if (tree == tree.Parent.Right)
                {
                    tree.Parent.Right = tree.Left;
                }
                return true;
            }

            if (tree.Left == null && tree.Right != null)
            {
                tree.Right.Parent = tree.Parent;
                if (tree == tree.Parent.Left)
                {
                    tree.Parent.Left = tree.Right;
                }
                else if (tree == tree.Parent.Right)
                {
                    tree.Parent.Right = tree.Right;
                }
                return true;
            }

            if (tree.Right != null && tree.Left != null)
            {
                curTree = tree.Right;

                while (curTree.Left != null)
                {
                    curTree = curTree.Left;
                }

                if (curTree.Parent == tree)
                {
                    curTree.Left = tree.Left;
                    tree.Left.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.Left)
                    {
                        tree.Parent.Left = curTree;
                    }
                    else if (tree == tree.Parent.Right)
                    {
                        tree.Parent.Right = curTree;
                    }
                    return true;
                }
                else
                {
                    if (curTree.Right != null)
                    {
                        curTree.Right.Parent = curTree.Parent;
                    }
                    curTree.Parent.Left = curTree.Right;
                    curTree.Right = tree.Right;
                    curTree.Left = tree.Left;
                    tree.Left.Parent = curTree;
                    tree.Right.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.Left)
                    {
                        tree.Parent.Left = curTree;
                    }
                    else if (tree == tree.Parent.Right)
                    {
                        tree.Parent.Right = curTree;
                    }

                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
