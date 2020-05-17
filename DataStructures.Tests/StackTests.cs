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
            stack.Push(5);


            //Assert
            Assert.Equal(expected, stack.Peek());

        }

        [Fact]
        public void I_can_has_many_push()
        {
            // Arrange
            Stack<int> newStack = new Stack<int>();


            // Act
            newStack.Push(5);
            newStack.Push(9);
            newStack.Push(3);
            newStack.Push(100);

            // Assert
            Assert.Equal(4, newStack.count);
            Assert.Equal(100, newStack.Peek());

        }

        [Fact]
        public void I_can_peek()
        {
            // Arrange
            Stack<string> newStack = new Stack<string>();
            newStack.Push("Charmander");
            newStack.Push("Pikachu");

            // Act
            string actual = newStack.Peek();

            // Assert
            Assert.Equal("Pikachu", actual);
        }
    }
}
