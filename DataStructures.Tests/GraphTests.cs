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
        public void I_can_add_a_node()
        {
            //Arrange
            Graph<int> testGraph = new Graph<int>();
            
            //Act
            newGraph.AddNode(7);

            //Assert
            Assert.Contains(7, testGraph);
        }
    }
}