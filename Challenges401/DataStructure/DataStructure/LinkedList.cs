using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;

        public void Insert(int value)
        {
            this.head = new Node(value);
        }

        public class Node
        {
            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }

            public int Value { get; set; }
            public Node Next { get; set; }
        }
    }
}
