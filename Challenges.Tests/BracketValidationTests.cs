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
        public void I_can_push_bracket()
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
        public void I_can_push_many_brackets()
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
            Assert.Equal('<', brackets.Peek());

        }

        [Fact]
        public void I_can_pop_a_bracket()
        {
            // Arrange
            Stack<char> brackets = new Stack<char>();
            brackets.Push('{');
            brackets.Push('(');
            brackets.Push('<');
            brackets.Push('<');

            // Act
            brackets.Pop();
            brackets.Pop();

            // Assert
            Assert.Equal('(', brackets.Peek());
        }

        [Theory]
        [InlineData("<({})>", true)]
        [InlineData("<({)>", false)]
        [InlineData("()[[codefellows]]", true)]
        [InlineData("<})>", false)]
        [InlineData(">", false)]
        [InlineData("(", false)]
        [InlineData("<yuu({wee}woo)>", true)]
        [InlineData("<({[", false)]

        public void I_can_validate_brackets(string input, bool expected)
        {
            // Arrange
            // from data

            // Act
            bool actual = BracketValidation.MultiBracketValidation(input);

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
