using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void New_list_is_empty()
        {
            string value = "";               

            LinkedList list = new LinkedList(value);

            Assert.Equal("", list.ToString());
        }
       
    }
}
