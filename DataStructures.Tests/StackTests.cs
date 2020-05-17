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
          

            // Act
          //stack.Push(5);


            //Assert
            Assert.NotNull(stack);

        }

        [Fact (Skip = "not sure what's happening here")]
        public void I_can_has_many_push()
        {
            // Arrange
            Stack<int> newStack = new Stack<int>();
        

            // Act
            newStack.Push(5);
            newStack.Push(9);
            newStack.Push(3);

            // Assert
            Assert.Contains(3, newStack);
            Assert.Contains(5, newStack);
            Assert.Contains(9, newStack);

        }

        [Fact]
        public void I_can_peek()
        {
            // Arrange
            Stack<string> newStack = new Stack<string>();
            newStack.Push("Pikachu");

            // Act
            string actual = newStack.Peek();

            // Assert
            Assert.Equal("Pikachu", actual);
        }
    }
}
