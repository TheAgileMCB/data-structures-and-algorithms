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

        public void DequeueOne (Node item)
        {
            var animal = All.Dequeue();

            if (animal.Value == Animal.Cat)
            {
                Cats.DequeueOne(animal);
            }
            else
            {
                Dogs.DequeueOne(animal);
            }
        }

        public void DequeueDog()
        {
            var dogNoMore = Dogs.Dequeue();

            All.DequeueOne(dogNoMore);
        }

        public void DequeueCat()
        {
            var catNoMore = Cats.Dequeue();

            All.DequeueOne(catNoMore);
        }

    }

    public class Queue
    {
        Node head = null;
        Node tail = null;
        public int count = 0;

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

        public Node DequeueOne(Node item)
        {
            Node current = head;
            Node previous = null;

            Node dequeued = null;

            while (current != null)
            {
                Node next = current.Next;

                if(current == item) 
                {
                    dequeued = current;

                    if (previous == null)
                    {
                        head = next;
                        //current = null;
                        break;
                    }
                    else
                    {
                        current = next;
                        previous.Next = current;

                        if (current.Next == null)
                        {
                            tail = current;
                        }
                    }

                    count--;
                }

                previous = current;
                current = current.Next;
            }

            return dequeued;
        }

        public Node Dequeue()
        {
            Node dequeued = null;
            Node current = head;

            if (count > 0)
            {
                dequeued = head;
                head = head.Next;
                count--;
            }

            return dequeued;
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
