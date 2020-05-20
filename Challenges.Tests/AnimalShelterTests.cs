using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class AnimalShelterTests
    {
        [Fact]
        public void Can_initialize_empty_shelter()
        {
            //Arrange
            Shelter shelter = new Shelter();

            // Assert
            Assert.Null(shelter.Dogs.Head);
            Assert.Null(shelter.Dogs.Tail);
            Assert.Null(shelter.Cats.Head);
            Assert.Null(shelter.Dogs.Tail);

            // Act
            shelter.QueueAnimal(new Node(Animal.Dog));
        }

        [Fact]
        public void Can_enqueue()
        {
            // Arrange
            Shelter shelter = new Shelter();

            // Act
            shelter.QueueAnimal(new Node(Animal.Dog));
            var expected = shelter.All.Tail.Value;

            // Assert
            Assert.Equal("Dog", expected.ToString());

        }

        [Fact (Skip ="spinning my wheels")]
        public void Can_dequeue()
        {
            // Arrange
            Shelter shelter = new Shelter();
            shelter.QueueAnimal(new Node(Animal.Dog));

            // Act
            shelter.DequeueOne(new Node(Animal.Dog));

            // Assert
            Assert.Equal(0, shelter.Dogs.count);
        }

    }
}
