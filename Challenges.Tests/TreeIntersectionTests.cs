using DataStructures.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class TreeIntersectionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 5, 7, 8, 9, 99, 100, 150 }, new int[] { 1, 8, 90, 54, 657, 12, 9, 5 }, new string[] { "1", "5", "8", "9" })]
        [InlineData(new int[] { 200, 2000, 5, 555, 789 }, new int[] { 2000, 555, 888, 123,3222 }, new string[] { "2000", "555" })]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 2, 1, 1, 1, 1 }, new string[] { "1", "1", "1", "1", "1" })]
        [InlineData(new int[] { 1, 5, 7, 8, 9 }, new int[] { 2, 22, 222 }, new string[] { })]
        [InlineData(new int[] { }, new int[] { }, new string[] { })]

        public void Can_return_list(int[] arrOne, int[] arrTwo, string[] expected)
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int> { };
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int> { };

            for(int i = 0; i <arrOne.Length; i++)
            {
                treeOne.Add(arrOne[i]);
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                treeTwo.Add(arrTwo[i]);
            }

            //Act
            List<string> actual = Hashtables.TreeIntersection.Tree_Intersection(treeOne, treeTwo);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
