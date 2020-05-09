using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;

        //public void MyList()
        //{
        //    head = null;
        //}

        public void Insert(int value)
        {
            //if (head == null)
            //{
            this.head = new Node(value);
            //}
            //else
            //{
            //    Node temp = new Node(value);
            //    temp.Next = head;
            //    head = temp;
            //}
        }

        public override string ToString()
        {
            //Console.Write("{" + head.Value + "} -> ");
            if (head != null)
            {
                return "{" + $"{head.Value.ToString()}" + "} -> ";
            }
            else
                return "NULL";
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
