using System;
using System.Text;
using Xunit;
using DataStructures;

namespace Challenges.Tests
{
    public class BracketValidationTests
    {
        [Fact]
        public void Peek_empty_stack_throws()
        {
            // Arrange
            Stack<char> bracket = new Stack<char>();

            // Assert
            Assert.Throws<StackEmptyException>(() =>
            {
                // Act
                bracket.Peek();
            });
        }

        [Fact(Skip = "pulled from StackTests")]
        public void I_can_has_push()
        {
            // Arrange
            Stack<char> brackets = new Stack<char>();
            char expected = };

        // Act
        stack.Push(});


            //Assert
            Assert.Equal(expected, stack.Peek());

        }

        [Fact(Skip = "pulled from StackTests")]
        public void I_can_has_many_push()
        {
            // Arrange
            Stack<char> newStack = new Stack<char>();


            // Act
            newStack.Push(});
            newStack.Push());
            newStack.Push(>);
            newStack.Push(>);

            // Assert
            Assert.Equal(4, newStack.count);
            Assert.Equal(100, newStack.Peek());

        }
    }
}
