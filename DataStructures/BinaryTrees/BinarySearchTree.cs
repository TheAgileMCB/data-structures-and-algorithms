using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    public class BinarySearchTree<T> : Tree<T> where
        T : IComparable<T>
    {
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
                    if (nodeToBeAdded.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public bool Contains (T key)
        {
            return IfNodeExists(ReturnRoot(), key);
        }
        public bool IfNodeExists(Node root, T key)
        {
            if (root == null)
                return false;

            int compare = key.CompareTo(root.Value);

            if ( compare == 0)
                return true;

            bool result1 = IfNodeExists(root.Left, key);

            if (result1)
                return true;

            bool result2 = IfNodeExists(root.Right, key);

            
                return result2;
        }

    }
}
