using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class GraphTests
    {
        [Fact]
        public void Can_add_a_node()
        {
            // Arrange
            Graph<int> testGraph = new Graph<int>();
            
            // Act
            testGraph.AddNode(7);

            // Assert
            Assert.Contains(7, testGraph.GetNodes());
        }

        [Fact]
        public void Can_get_all_nodes()
        {
            // Arrange
            List<int> expected = new List<int> { 1, 4, 7, 3, 2, 9, 122, 45, 56 };
            Graph<int> testGraph = new Graph<int>();

            // Act
            foreach (int item in expected)
            {
                testGraph.AddNode(item);
            }

            // Assert
            Assert.Equal(expected, testGraph.GetNodes());
        }

        [Fact]
        public void Can_traverse_deeply()
        {
            // Arrange
            List<int> actual = new List<int> { 1, 4, 7, 3, 2, 9, 122, 45, 56 };
            Graph<int> testGraph = new Graph<int>();
            HashSet<int> expected = new HashSet<int>() { 1, 4, 7, 3, 2, 9, 122 };

            foreach (int item in actual)
            {
                testGraph.AddNode(item);
            }
            testGraph.AddEdge(1, 4);
            testGraph.AddEdge(4, 7);
            //testGraph.AddEdge(7, 3);
            testGraph.AddEdge(3, 2);
            testGraph.AddEdge(2, 9);
            testGraph.AddEdge(9, 122); 
            testGraph.AddEdge(1, 3);

            // Act
            HashSet<int> trueActual = testGraph.DFT(testGraph, 1);

            // Assert
            Assert.Equal(expected, trueActual);
        }

    }
}