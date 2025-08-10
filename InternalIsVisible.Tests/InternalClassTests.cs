using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternalIsVisible.Core;

namespace InternalIsVisible.Tests
{
    public class InternalClassTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new InternalCalculator();

            // Act
            var result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void SecretMessage_ReturnsExpectedValue()
        {
            // Act
            var message = InternalCalculator.SecretMessage;

            // Assert
            Assert.Equal("Some Hidden things!", message);
        }
    }
}
