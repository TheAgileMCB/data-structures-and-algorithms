using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class InsertSortTests
    {
        [Theory]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
        public void Can_sort(int[] input, int[] expected)
        {
            // Arrange (Theory)

            // Act
            int[] actual = Challenges.InsertSort.InsertionSort(input);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
