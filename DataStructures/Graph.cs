﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class Graph<T>
    {
        Dictionary<T, Dictionary<T, int>> Nodes;

        public Graph()
        {
            Nodes = new Dictionary<T, Dictionary<T, int>>();
        }

        public bool AddNode(T value)
        {
            if (Nodes.ContainsKey(value)) return false;

            Nodes.Add(value, new Dictionary<T, int>());
            return true;
        }

        public bool AddEdge(T firstNodeValue, T secondNodeValue, int weight = 1, bool oneWay = false)
        {
            if (!Nodes.ContainsKey(firstNodeValue) || !Nodes.ContainsKey(secondNodeValue)) return false;

            Dictionary<T, int> nodeOne = Nodes[firstNodeValue];
            Dictionary<T, int> nodeTwo = Nodes[secondNodeValue];

            if (nodeOne.ContainsKey(firstNodeValue)) return false;

            if (!oneWay && !firstNodeValue.Equals(secondNodeValue))
            {
                if (nodeTwo.ContainsKey(firstNodeValue)) return false;
                nodeTwo.Add(firstNodeValue, weight);
            }

            nodeOne.Add(secondNodeValue, weight);
            return true;

        }

        public List<T> GetNodes()
        {
            //if (Nodes.Keys.Count < 1) return null;
            return Nodes.Keys.ToList();
        }

        public Dictionary<T, int> GetNeighbors(T value)
        {
            if (!Nodes.ContainsKey(value)) return null;

            return Nodes[value];
        }

        public int Size()
        {
            return Nodes.Keys.Count;
        }

        public HashSet<T> DFT<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.Nodes.ContainsKey(start))
                return visited;

            var stack = new System.Collections.Generic.Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.Nodes[vertex])
                    if (!visited.Contains(neighbor.Key))
                        stack.Push(neighbor.Key);
            }

            return visited;
        }
    }
}
