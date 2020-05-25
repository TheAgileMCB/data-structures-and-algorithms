using DataStructures.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class TreeTests
    {
        [Fact]
        public void Can_make_empty()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();

            // Assert
            Assert.Null(testTree.Root);

            // Act
            testTree.Add(5);

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

        [Fact]
        public void Can_add_three_node()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            int root = 5;
            int left = 1;
            int right = 9;


            // Act
            testTree.Add(5);
            testTree.Add(9);
            testTree.Add(1);


            // Assert
            Assert.Equal(root, testTree.Root.Value);
            Assert.Equal(left, testTree.Root.Left.Value);
            Assert.Equal(right, testTree.Root.Right.Value);

        }

        [Fact]
        public void Can_preorder_traverse()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(9);
            testTree.Add(1);
            IEnumerable<int> expected = new int[] { 5, 1, 9 };


            // Act
            IEnumerable<int> actual = testTree.PreOrder(testTree.ReturnRoot());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_preorder_big_traverse()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(9);
            testTree.Add(1);
            testTree.Add(8);
            testTree.Add(12);
            testTree.Add(2);
            IEnumerable<int> expected = new int[] { 5, 1, 2, 9, 8, 12 };


            // Act
            IEnumerable<int> actual = testTree.PreOrder(testTree.ReturnRoot());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_inorder_big_traverse()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(9);
            testTree.Add(7);
            testTree.Add(1);
            testTree.Add(12);
            testTree.Add(2);
            IEnumerable<int> expected = new int[] { 1, 2, 5, 7, 9, 12 };


            // Act
            IEnumerable<int> actual = testTree.InOrder(testTree.ReturnRoot());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_postorder_big_traverse()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(7);
            testTree.Add(9);
            testTree.Add(1);
            testTree.Add(12);
            testTree.Add(2);
            IEnumerable<int> expected = new int[] { 2, 1, 12, 9, 7, 5 };


            // Act
            IEnumerable<int> actual = testTree.PostOrder(testTree.ReturnRoot());

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void It_contains()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(7);
            testTree.Add(9);

            // Act
         
            // Assert
            Assert.True(testTree.Contains(1));
        }
    }
}