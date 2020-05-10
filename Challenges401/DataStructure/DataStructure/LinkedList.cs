using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;
        private Node current;

        public void Insert(int value)
        {
            // this.head = new Node(value);

            Node tempNode = new Node(value);

            if (head != null)
            {
                tempNode.Next = this.head;
            }

            head = tempNode;
            current = tempNode;

        }



        public bool Includes(int value)
        {
            current = head;
            while ((current != null) && (current.Value != value))
            {
                current = current.Next;
            }
            if (current != null) return true;

            else return false;

        }

        public override string ToString()
        {
            string linkedListOutput = "";

            if (head != null)
            {
                linkedListOutput += $"{{{current.Value}}}";
                while (current.Next != null)
                {
                    current = current.Next;
                    linkedListOutput += $" -> {{{current.Value}}}";
                }
            }
            return linkedListOutput + " -> NULL";

        }

        public class Node
        {
            public Node(int value)
            {
                Value = value;
                Next = null;
            }

            public int Value { get; set; }
            public Node Next { get; set; }
        }
    }


}
