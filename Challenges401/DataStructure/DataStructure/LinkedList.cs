using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node head;
        private Node current;

        public void Insert(int value)
        {
            try
            {
                Node tempNode = new Node(value);

                if (head != null)
                {
                    tempNode.Next = head;
                }

                head = tempNode;
                current = tempNode;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }



        public bool Includes(int value)
        {
            try
            {
                current = head;
                while ((current != null) && (current.Value != value))
                {
                    current = current.Next;
                }
                if (current != null) return true;

                else return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public override string ToString()
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "Sorry, something went wrong.";
            }

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
