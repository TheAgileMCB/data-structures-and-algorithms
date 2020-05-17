using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        private Node top;

        public T Push(T value)
        {
            Node newNode = new Node(value);

            if (top != null)
            {

                newNode.Next = top;

            }

            top = newNode;
            return top.Value;
        }


            public T Pop() { return default; }

        public T Peek()
        {

            if (top == null) 
                throw new StackEmptyException();
            else
                return top.Value;
        }

        public class Node
        {
            public Node(T value)
            {
                Value = value;
                Next = null;
            }

            public Node Next { get; set; }
            public T Value { get; set; }
        }
    }
}
