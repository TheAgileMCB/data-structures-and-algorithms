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
            Assert.Equal("{1} -> NULL", list.ToString());
        }

        [Fact]
        public void Can_add_2_to_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);
            list.Insert(4);

            //Assert
            Assert.Equal("{4} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void Can_add_3_to_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);
            list.Insert(4);
            list.Insert(5);


            //Assert
            Assert.Equal("{5} -> {4} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void Can_return_true()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int value = 1;

            // Act
            list.Insert(value);

            //Assert
            Assert.True(list.Includes(value));
        }

        [Fact]
        public void Can_return_false()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int value = 1;

            // Act
            list.Insert(value);

            //Assert
            Assert.False(list.Includes(777));
        }

    }
}
