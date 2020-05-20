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

        [Fact]
        public void I_can_has_push()
        {
            // Arrange
            Stack<char> brackets = new Stack<char>();
            char expected = '{';

        // Act
        brackets.Push('{');


            //Assert
            Assert.Equal(expected, brackets.Peek());

        }

        [Fact]
        public void I_can_has_many_push()
        {
            // Arrange
            Stack<char> brackets = new Stack<char>();


            // Act
            brackets.Push('{');
            brackets.Push('(');
            brackets.Push('<');
            brackets.Push('<');

            // Assert
            Assert.Equal(4, brackets.count);
            Assert.Equal('{', brackets.Peek());

        }
    }
}
