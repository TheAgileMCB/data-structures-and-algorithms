using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace DataStructures.Tests
{
    public class QueueWithStackTests
    {
        [Fact]
        public void Peek_empty_stack_throws()
        {
            // Arrange
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            stack1.Push(4);
            stack1.Push(9);
            stack1.Push(2);
            var expected = 2;

            // Act
            stack2.Push(stack1.Pop());


            // Assert
            Assert.Equal(expected, stack2.Peek());

        }
    }
}