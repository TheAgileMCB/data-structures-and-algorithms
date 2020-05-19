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
        public Queue All { get; set; }
        public Shelter()
        {
            Dogs = new Queue();
            Cats = new Queue();
            All = new Queue();
        }

        public void QueueAnimal(Node animal)
        {
            All.Enqueue(animal);

            if (animal.Value == Animal.Cat)
            {
                Cats.Enqueue(animal);
            }
            else
            {
                Dogs.Enqueue(animal);
            }
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
