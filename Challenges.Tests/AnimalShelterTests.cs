using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class AnimalShelterTests
    {
        [Fact]
        public void Can_enqueue()
        {
            // Arrange
            Shelter shelter = new Shelter();
            // Act
            shelter.QueueAnimal(new Node(Animal.Dog));
            var expected = shelter.All.Tail.Value;

            // Assert
            Assert.Contains("Dog", expected.ToString());
        }

        [Fact (Skip ="not ready yet")]
        public void Can_dequeue()
        {

        }

    }
}
