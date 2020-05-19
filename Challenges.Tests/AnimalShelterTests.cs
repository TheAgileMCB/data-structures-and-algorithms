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
            AnimalShelter shelter = new AnimalShelter();
            // Act
            shelter.Enqueue(Dog);

            // Assert
            Assert.Contains(Dog, shelter);
        }

        [Fact (Skip ="not ready yet")]
        public void Can_dequeue()
        {

        }

    }
}
