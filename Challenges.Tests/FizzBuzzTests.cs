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
        public void Can_get_number()
        {
            // Arrange
            BinarySearchTree<int> actualTree = new BinarySearchTree<int>();
            actualTree.Add(15); // root
            actualTree.Add(3);  // left child
            actualTree.Add(30); // right child
            actualTree.Add(45); //right right child
            actualTree.Add(5); // left right child
            actualTree.Add(9); // left right right child
            actualTree.Add(10); // left right right right child
            actualTree.Add(2); // left left child

            string expected = "2";

            // Act
            var actual = FizzBuzz.FizzBuzzTree(actualTree);

            // Assert
            Assert.Equal(expected, actual.Root.Left.Left.Value);
        }

        [Fact]
        public void Can_preorder()
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

            IEnumerable<string> expected = new string[]
                {
                "FizzBuzz",
                "Fizz",
                "2",
                "Buzz",
                "Fizz",
                "Buzz",
                "FizzBuzz",
                "FizzBuzz"
                };

            // Act
            var almostActual = FizzBuzz.FizzBuzzTree(actualTree);
            IEnumerable<string> actual = almostActual.PreOrder(almostActual.ReturnRoot());

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
