using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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
    }
}
