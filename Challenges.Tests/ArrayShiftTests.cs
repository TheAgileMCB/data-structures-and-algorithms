using System;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayShiftTests
    {
        [Theory]
        [InlineData(1, new int[0], new[] { 1 })]
        [InlineData(54, new[] { 7, 67, 1 }, new[] { 7, 67, 54, 1 })]
        [InlineData(54, new[] { 7, 67, 1, 8 }, new[] { 7, 67, 54, 1, 8 })]

        public void Can_shift_array(int value, int[] input, int[] expected)
        {
            // Arrange
            // from data

            // Act
            int[] result = ArrayShift.insertShiftArray(input, value);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
