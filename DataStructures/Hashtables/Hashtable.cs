using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Hashtables
{
    public class Hashtable
    {
        public class Node
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Node Next { get; set; }
            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        public int Buckets { get; set; }

        public int Hash(string key)
        {
            int index;
            byte[] bytesTotal = Encoding.ASCII.GetBytes(key);
            int asciiKey = 0;
            for (int i = 0; i < bytesTotal.Length; i++)
            {
                asciiKey += bytesTotal[i];
            }
            index = asciiKey * 701 % Buckets;
            return index;
        }

        public Node[] HashTableNode { get; set; }

        public Hashtable(int buckets)
        {
            Buckets = buckets;
            HashTableNode = new Node[buckets];
        }

        public void Add(string key, string value)
        {
            int index = Hash(key);
            Node newNode = new Node(key, value);

            if (HashTableNode[index] == null)
            {
                HashTableNode[index] = newNode;
            }
            else
            {
                //Node newNode = new Node(key, value);
                Node current = HashTableNode[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public string Get(string key)
        {
            string returnText = $"Cannot find key: {key}";
            int index = Hash(key);

            if (HashTableNode[index] == null)
            {
                return returnText;
            }

            if (HashTableNode[index] != null)
            {
                if (HashTableNode[index].Key == key)
                {
                    return HashTableNode[index].Value;
                }
                else
                {
                    Node current = HashTableNode[index];
                    while (current.Next != null)
                    {
                        current = current.Next;
                        if (current.Key == key)
                        {
                            return current.Value;
                        }
                    }
                }
            }

            return returnText;
        }

        public bool Contains(string key)
        {
            int index = Hash(key);
            if (HashTableNode[index] == null)
            {
                return false;
            }
            else
            {
                Node current = HashTableNode[index];
                if (HashTableNode[index].Key == key)
                    return true;
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Key == key)
                        return true;
                }
            }

            return false;
        }
    }
}
