using System;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Challenges
{
    public class Shelter
    {
        public Queue Dogs { get; set; }
        public Queue Cats { get; set; }
        //public Queue Dogs { get; set; }
        public Shelter()
        {
            Dogs = new Queue();
            Cats = new Queue();
            
        }

    }

    public class Queue
    {
        Node head = null;
        Node tail = null;
        int count = 0;

        public Node Head
        {
            get
            {
                return head;
            }
        }

        public Node Tail
        {
            get
            {
                return tail;
            }
        }

        public void Enqueue(Node newNode)
        {
            if (count == 0)
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
            }

            tail = newNode;
            count++;
        }
    }
    

    public enum Animal
    {
        Dog = 1,
        Cat = 2
    }

    

    public class Node
    {
        public Animal Value { get; set; }
        public Node Next { get; set; }

        public Node(Animal value)
        {
            this.Value = value;
        }

    }
}
