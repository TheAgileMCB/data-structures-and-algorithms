using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class HashtableTests
    {
        [Fact]
        public void Can_has_element()
        {
            // Arrange
            Hashtable testTable = new Hashtable(1);

            // Act
            testTable.Add("noodles", "spaghetti");

        // Assert
            Assert.True(testTable.Contains("noodles"));
        }
    }
}
