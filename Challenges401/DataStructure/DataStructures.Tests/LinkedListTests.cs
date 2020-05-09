using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void New_list_shows_null()
        {
            // Act
            LinkedList list = new LinkedList();

            // Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact]
        public void Can_add_to_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);

            //Assert
            Assert.Equal("{1} -> ", list.ToString());
        }

    }
}
