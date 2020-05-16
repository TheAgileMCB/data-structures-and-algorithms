using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DataStructures.Tests
{
    public class StackTests
    {
        [Fact]
        public void Peek_empty_stack_throws()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            // Assert
            Assert.Throws<StackEmptyException>(() =>
            {
                // Act
                stack.Peek();
            });
        }

        [Fact]
        public void I_can_haz_push()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();
            int expected = 5;

            // Act
            Stack<object> test = stack.Push(5);
            int actual = test.Value;

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
