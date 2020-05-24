using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Text;

namespace DataStructures.Binary_Trees
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }

        public Node ReturnRoot()
        {
            return Root;
        }

        public void Insert(T value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public IEnumerable<T> PreOrder(Node Root)
        {
            if (Root != null)
            {
                PreOrder(Root.Left);
                PreOrder(Root.Right);
            }
        }

        public IEnumerable<T> InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.Left);
                InOrder(Root.Right);
            }
            return
        }

        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.Left);
                PostOrder(Root.Right);
            }
            return
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Root { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}
