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

        [Fact]
        public void Can_binary_search_100()
        {
            // Arrange
            int[] input = new int[100];
            for(int i = 1; i < input.Length; i++)
            {
                input[i-1] = i;
            }

            int key = 65;
            int expected = 64;
            // Act
            int result = ArrayMethods.BinarySearch(key, input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_binary_search_1000()
        {
            // Arrange
            int[] input = new int[1000];
            for (int i = 1; i < input.Length; i++)
            {
                input[i-1] = i;
            }

            int key = 1;
            int expected = 0;
            // Act
            int result = ArrayMethods.BinarySearch(key, input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_binary_search_10000()
        {
            // Arrange
            int[] input = new int[10000];
            for (int i = 1; i < input.Length; i++)
            {
                input[i-1] = i;
            }

            int key = 678;
            int expected = 677;
            // Act
            int result = ArrayMethods.BinarySearch(key, input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_binary_search_100000()
        {
            // Arrange
            int[] input = new int[100000];
            for (int i = 1; i < input.Length; i++)
            {
                input[i-1] = i;
            }

            int key = 200000;
            int expected = -1;
            // Act
            int result = ArrayMethods.BinarySearch(key, input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}