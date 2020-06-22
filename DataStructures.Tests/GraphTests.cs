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
            List<int> expected = new List<int> { 1, 1, 4, 7, 3, 2, 9, 122, 45, 56 };
            Graph<int> testGraph = new Graph<int>();

            // Act
            foreach (int item in expected)
            {
                testGraph.AddNode(item);
            }

            // Assert
            Assert.Equal(expected, testGraph.GetNodes());
        }
    }
}