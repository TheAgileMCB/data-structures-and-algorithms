using System;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayShiftTests
    {
        [Theory]
        [InlineData(new[] { 7, 67, 1 }, 54, new[] { 7, 67, 54, 1 })]
        [InlineData(new[] { 7, 67, 1, 8 }, 54, new[] { 7, 67, 54, 1, 8 })]

        public void Can_shift_odd_length_array(int[] input, int num, int[] expected)
        {
            // Arrange
            // from input

            // Act
            int[] result = ArrayShift.insertShiftArray(input, num);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
