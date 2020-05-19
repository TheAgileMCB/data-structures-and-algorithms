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

        [Fact]
        public void Can_dequeue()
        {
            // Arrange
            Shelter shelter = new Shelter();
            shelter.QueueAnimal(new Node(Animal.Dog));

            // Act
            var expected = shelter.Dequeue(Dog);

            // Assert
            Assert.Equal("Dog", expected);
        }

    }
}
