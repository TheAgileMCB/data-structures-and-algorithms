using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    public class Tree<T> where
        T : IComparable<T>
    {
        public Node Root;
        public Tree()
        {
            Root = null;
        }

        public Node ReturnRoot()
        {
            return Root;
        }

        // Root -> Left -> Right
        public IEnumerable<T> PreOrder(Node root)
        {
            if (root == null)
                yield break;

                yield return root.Value;
            foreach (T item in PreOrder(root.Left))
                yield return item;

                foreach(T item in PreOrder(root.Right))
                yield return item; 
        }

        // Left -> Root -> Right
        public IEnumerable<T> InOrder(Node root)
        {
            if (root == null)
                yield break;

            
            foreach (T item in PreOrder(root.Left))
                yield return item;

            yield return root.Value;

            foreach (T item in PreOrder(root.Right))
                yield return item;
        }

        // Left -> Right -> Root
        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.Left);
                PostOrder(Root.Right);
                yield return Root.Value;
            }
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
