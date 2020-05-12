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

        [Fact]
        public void Can_add_to_end()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(4);
            list.Insert(5);

            // Act
            list.Append(9);


            //Assert
            Assert.Equal("{5} -> {4} -> {1} -> {9} -> NULL", list.ToString());
        }

        [Fact]
        public void Can_add_to_end_of_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            

            // Act
            list.Append(9);


            //Assert
            Assert.Equal("{9} -> NULL", list.ToString());
        }

        [Fact]
        public void Can_insert_before()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Append(9);

            // Act
            list.insertBefore(45, 9);


            //Assert
            Assert.Equal("{5} -> {45} -> {9} -> NULL", list.ToString());
        }

        //[Fact]
        //public void Can_return_null_if_insertBeforeMe_Does_not_exist()
        //{
        //    // Arrange
        //    LinkedList list = new LinkedList();
        //    list.Insert(5);


        //    // Act
        //    list.insertBefore(45, 9);


        //    //Assert
        //    Assert.Equal("NULL", list.ToString());
        //}

        [Fact]
        public void Can_insert_before_first_item()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Append(5);
            list.Append(9);

            // Act
            list.insertBefore(88, 3);


            //Assert
            Assert.Equal("{88} -> {3} -> {5} -> {9} -> NULL", list.ToString());
        }

        public void Can_insert_after()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Append(5);
            list.Append(9);

            // Act
            list.insertAfter(88, 3);


            //Assert
            Assert.Equal("{3} -> {5} -> {88} -> {9} -> NULL", list.ToString());
        }
    }
}