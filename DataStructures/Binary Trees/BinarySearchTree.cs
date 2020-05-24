using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Binary_Trees
{
    public class BinarySearchTree<T> where
        T : IComparable<T>
    {
        public Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }

        public Node ReturnRoot()
        {
            return Root;
        }
        public void Add(T nodeToBeAdded)
        {
            Node newNode = new Node();
            newNode.Value = nodeToBeAdded;
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
                    if (nodeToBeAdded.CompareTo < current.Value)
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

        //public bool Contains(T nodeToBeSearched)
        //{

        //}
    }
}
