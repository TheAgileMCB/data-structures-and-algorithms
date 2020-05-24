using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Text;

namespace DataStructures.Binary_Trees
{
    public class BinaryTree<T> where
        T : IComparable<T>
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

        public IEnumerable<T> PreOrder(Node Root)
        {
            if (Root != null)
            {
                yield return Root.Value;
                PreOrder(Root.Left);
                PreOrder(Root.Right);
            }
        }

        public IEnumerable<T> InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.Left);
                yield return Root.Value;
                InOrder(Root.Right);
            }
        }

        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.Left);
                PostOrder(Root.Right);
                yield return Root.Value;
            }
        }
    }
}
