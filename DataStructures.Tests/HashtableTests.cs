using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
/// <summary>
/// Edge Cases
/// 1. Key doesn't exist *and* bucket is empty
/// 2. Key doesn't exist *but* bucket is not empty
///  2a. Hash code matches, but not equal
///  "cat" vs "act"
///  2b. Hash code doesn't match
/// 3. Key does exist and we need to *replace* the existing value
/// </summary>
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

        [Fact]
        public void can_find_first_level_element()
        {
            // Arrange
            Hashtable testTable = new Hashtable(1);
            testTable.Add("noodles", "spaghetti");
            testTable.Add("bread", "baguette");
            string expected = "spaghetti";

            // Act
            string actual = testTable.Get("noodles");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void can_find_lower_level_element()
        {
            // Arrange
            Hashtable testTable = new Hashtable(1);
            testTable.Add("noodles", "spaghetti");
            testTable.Add("bread", "baguette");
            string expected = "baguette";

            // Act
            string actual = testTable.Get("bread");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_contains_lower_level_elementz()
        {
            // Arrange
            Hashtable testTable = new Hashtable(1);

            // Act
            testTable.Add("noodles", "spaghetti");
            testTable.Add("bread", "baguette");
            testTable.Add("cake", "a lie");
            testTable.Add("cheese", "swiss");
            testTable.Add("casserole", "tater tot");


            // Assert
            Assert.True(testTable.Contains("cheese"));
        }
    }
}