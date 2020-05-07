using System;
using Xunit;

namespace Challenges.Tests
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(1, new int[0], -1)]
        [InlineData(54, new[] { 1, 3, 6, 54 }, 3)]
        [InlineData(54, new[] { 7, 9, 10, 80 }, -1)]
        [InlineData(8, new[] { 7, 8, 9, 14, 22, 45, 67, 90, 100, 111 }, 1)]

        public void Can_binary_search(int key, int[] input, int expected)
        {
            // Arrange
            // from data

            // Act
            int result = ArrayMethods.BinarySearch(key, input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}