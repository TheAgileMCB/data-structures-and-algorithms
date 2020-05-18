using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T> : IEnumerable<T>
    {
        private Node top { get; set; }
        public T[] items;
        public int count;

        public void Push(T value)
        {
            Node newNode = new Node(value) { Next = top };
           
            top = newNode;
            count++;
            
        }


            public T Pop() { return default; }

        public T Peek()
        {

            if (top == null) 
                throw new StackEmptyException();
            else
                return top.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        // Non-generic, just do this because we have to
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
