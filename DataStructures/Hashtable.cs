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
            int bucketIndex;
            byte[] bytesTotal = Encoding.ASCII.GetBytes(key);
            int asciiKey = 0;
            for (int i = 0; i < bytesTotal.Length; i++)
            {
                asciiKey += bytesTotal[i];
            }
            bucketIndex = asciiKey * 701;
            return bucketIndex;
        }

        public Node[] HashTableNode { get; set; }

        public Hashtable(int buckets)
        {
            Buckets = buckets;
            HashTableNode = new Node[buckets];
        }

        public void Add(string key, string value)
        {
            int bucketIndex = Hash(key) % Buckets;
            Node newNode = new Node(key, value);

            if (HashTableNode[bucketIndex] == null)
            {
                HashTableNode[bucketIndex] = newNode;
            }
            else
            {
                //Node newNode = new Node(key, value);
                Node current = HashTableNode[bucketIndex];
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
            int bucketIndex = Hash(key) % Buckets;

            if (HashTableNode[bucketIndex] == null)
            {
                return returnText;
            }

            if (HashTableNode[bucketIndex] != null)
            {
                if (HashTableNode[bucketIndex].Key == key)
                {
                    return HashTableNode[bucketIndex].Value;
                }
                else
                {
                    Node current = HashTableNode[bucketIndex];
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
            int bucketIndex = Hash(key) % Buckets;
            if (HashTableNode[bucketIndex] == null)
            {
                return false;
            }
            else
            {
                Node current = HashTableNode[bucketIndex];
                if (HashTableNode[bucketIndex].Key == key)
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
