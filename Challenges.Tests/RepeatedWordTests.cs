using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class RepeatedWordTests
    {
        [Theory]
        [InlineData ("Once upon a time, there was a brave princess who...", "a")]
        [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...", "it")]
        [InlineData("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...", "summer")]
        public void Can_find_repeated_word(string input, string actual)
        {
            // Assign
            // inline data

            // Act
            string expected = Hashtables.HashWord.RepeatedWord(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
