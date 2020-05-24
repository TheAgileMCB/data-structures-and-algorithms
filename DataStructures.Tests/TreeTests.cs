using DataStructures.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class TreeTests
    {
        [Fact (Skip = "how to assert a tree is empty?")]
        public void Can_make_empty()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();

            // Act


            // Assert
            

        }

        [Fact]
        public void Can_add_one_node()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            int expected = 5;


            // Act
            testTree.Add(5);

            // Assert
            Assert.Equal(expected, testTree.Root.Value);

        }
    }
}
