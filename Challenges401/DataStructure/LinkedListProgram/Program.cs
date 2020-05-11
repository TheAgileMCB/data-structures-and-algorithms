using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace valueStructures.Program
{
    public class Node
    {
        public int value;
            public Node next;
        public Node(int i)
        {
            value = i;
            next = null;
        }



        public void Print()
        {
            Console.Write("{" + value + "} -> ");
            if (next != null)
            {
                next.Print();
            }
        }
    }

    public class LinkList
    {
        public Node headNode;

        public LinkList()
        {
            headNode = null;
        }

        public void Insert(int value)
        {
            if (headNode == null)
            {
                headNode = new Node(value);
            }
            else
            {
                Node temp = new Node(value);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public bool Includes(LinkList list, int value)
        {
            return list.Contains(true);
        }
       

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkList list = new LinkList();

            list.Insert(4);
            list.Insert(7);
            list.Insert(9);
            list.Insert(12);
            list.Print();




            //LinkedList list = new LinkedList();

            //list.Insert(6);
            //list.Insert(5);
            //list.Insert(9);
            //list.Insert(8);
            //list.Insert(1);
            //list.ToString();
        }
    }
}
