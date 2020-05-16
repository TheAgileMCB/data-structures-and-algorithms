using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        public Node top;

        public void Push(T value) { }

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
