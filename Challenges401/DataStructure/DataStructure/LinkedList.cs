using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;

        public Node ListHead()
        {
            head = null;
            return head;
        }

        public void Insert(int value)
        {
            if (head == null)
            {
            this.head = new Node(value);
            }
            else
            {
                Node temp = new Node(value);
                temp.Next = head;
                head = temp;
            }
        }

        public void ToString()
        {
            if (head != null)
            {
                head.ToString();
            }
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
