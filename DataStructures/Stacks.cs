using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        private Node top;

        public void Push(T value) { }

        public T Pop() { return default; }

        public T Peek()
        {
            if (top == null) throw new StackEmptyException();

            return default;
        }

        private class Node
        {
            Node Next { get; set; }
            T Value { get; set; }
        }
    }
}
