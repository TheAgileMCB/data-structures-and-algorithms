using DataStructures.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Can_get_fizzbuzz()
        {
            // Arrange
            BinarySearchTree<int> actualTree = new BinarySearchTree<int>();
            actualTree.Add(15);
            actualTree.Add(3);
            actualTree.Add(30);
            actualTree.Add(45);
            actualTree.Add(5);
            actualTree.Add(9);
            actualTree.Add(10);
            actualTree.Add(2);
            
            string expected = "FizzBuzz";

            // Act
           var actual = FizzBuzz.FizzBuzzTree(actualTree);

            // Assert
            Assert.Equal(expected, actual.Root.Value);
        }

        [Fact]
        public void Can_get_fizz()
        {
            // Arrange
            BinarySearchTree<int> actualTree = new BinarySearchTree<int>();
            actualTree.Add(15);
            actualTree.Add(3);
            actualTree.Add(30);
            actualTree.Add(45);
            actualTree.Add(5);
            actualTree.Add(9);
            actualTree.Add(10);
            actualTree.Add(2);

            string expected = "Fizz";

            // Act
            var actual = FizzBuzz.FizzBuzzTree(actualTree);

            // Assert
            Assert.Equal(expected, actual.Root.Left.Value);
        }

        [Fact]
        public void Can_get_buzz()
        {
            // Arrange
            BinarySearchTree<int> actualTree = new BinarySearchTree<int>();
            actualTree.Add(15);
            actualTree.Add(3);
            actualTree.Add(30);
            actualTree.Add(45);
            actualTree.Add(5);
            actualTree.Add(9);
            actualTree.Add(10);
            actualTree.Add(2);

            string expected = "FizzBuzz";

            // Act
            var actual = FizzBuzz.FizzBuzzTree(actualTree);

            // Assert
            Assert.Equal(expected, actual.Root.Left.Right.Value);
        }
    }
}
