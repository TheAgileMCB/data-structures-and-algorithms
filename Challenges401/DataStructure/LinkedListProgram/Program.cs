using System;

namespace DataStructures.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Insert(6);
            list.Insert(5);
            list.Insert(9);
            list.Insert(8);
            list.Insert(1);
            list.ToString();
        }
    }
}
