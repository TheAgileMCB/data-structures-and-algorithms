using System;

namespace DataStructures
{
    public class LinkedList
    {
        // establishes to head and current nodes for traversing to list
        private Node head;
        private Node current;

        public void Insert(int value)
        {
            try
            {
                // assigns the new node to a temporary holding node
                Node tempNode = new Node(value);

                // checks that the list head exists
                if (head != null)
                {
                    // if it does, sets the temp node to point at the current head
                    tempNode.Next = head;
                }

                // sets the value of the temp node to the head
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
                // assigns the head to the current ndoe
                current = head;
                //traverses the nodes, verifying that the nodes have content and that they are not the desired value
                while ((current != null) && (current.Value != value))
                {
                    // assigns the next value to the current
                    current = current.Next;
                }

                // if the loop returns a value, it is the desired value so it returns true
                if (current != null) return true;

                //otherwise, it returns false
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
                // establish an empty string
                string linkedListOutput = "";

                // perform the actions if the nead node has data
                if (head != null)
                {
                    // add the current value of the node the string until the next node returns null
                    linkedListOutput += $"{{{current.Value}}}";
                    while (current.Next != null)
                    {
                        // adds the subsequent values to the string
                        current = current.Next;
                        linkedListOutput += $" -> {{{current.Value}}}";
                    }
                }
                // returns the string and concatenates the final null value
                return linkedListOutput + " -> NULL";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "Sorry, something went wrong.";
            }

        }
        /// <summary>
        /// Establishes the node class, getting and setting both an int value and the Node next
        /// </summary>
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
