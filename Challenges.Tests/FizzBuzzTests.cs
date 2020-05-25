﻿using DataStructures.BinaryTrees;
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
            
            string expected = "fizzbuzz";

            // Act
            FizzBuzzTree(actualTree);

            // Assert
            Assert.Equal(expected, actualTree.Root.Value);
        }
    }
}
