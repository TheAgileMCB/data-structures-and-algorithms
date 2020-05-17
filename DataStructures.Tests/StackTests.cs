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
        public void I_can_has_push()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            int expected = 5;

            // Act
           int test = stack.Push(5);
         

            //Assert
            Assert.Equal(expected, test);

        }
    }
}
