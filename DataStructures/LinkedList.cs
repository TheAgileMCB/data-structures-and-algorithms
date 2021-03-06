﻿using System;

namespace DataStructures
{
    public class LinkedList
    {
        // establishes to head and current nodes for traversing to list
        private Node head;

        public void Insert(int value)
        {
            try
            {
                // assigns the new node to a temporary holding node
                Node newNode = new Node(value);

                // checks that the list head exists
                if (head != null)
                {
                    // if it does, sets the temp node to point at the current head
                    newNode.Next = head;
                }

                // sets the value of the temp node to the head
                head = newNode;
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
                Node current = head;
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
                Node current = head;
                // establish an empty string
                string result = "";

                // add the current value of the node the string until the next node returns null

                while (current != null)
                {
                    // adds the subsequent values to the string
                    result += $"{{{current.Value}}} -> ";

                    // traverse
                    current = current.Next;
                }

                // returns the string and concatenates the final null value
                return result + "NULL";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "Sorry, something went wrong.";
            }

        }

        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = null;

                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void InsertBefore(int value, int insertBeforeMe)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                // throw new ArgumentException("Value not found to insert before");
            }
            else if (head.Value == insertBeforeMe)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    if (current.Next.Value == insertBeforeMe)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }

                    current = current.Next;
                }

                throw new ArgumentException("Value not found.");
            }
        }

        public void InsertAfter(int value, int insertAfterMe)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = null;
                Node current = head;

                while (current.Value != insertAfterMe)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public int Search(int value, int negativeIndex)
        {
            int length = 0;
            Node current = head;

            if(head == null)
            {
                throw new Exception("Nothing is here!");
            }

            while (current != null)
            {
                current = current.Next;
                    length++;
            }

            int position = length - negativeIndex;

            if(length < negativeIndex)
            {
                throw new Exception("The value searched is too big.");
            }

            current = head;

            if (length == negativeIndex)
            {
                return current.Value;
            }
            else
            {
                for(int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                return current.Value;
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
