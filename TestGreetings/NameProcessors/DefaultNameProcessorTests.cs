using System;
using Greetings.NameProcessors;
using FluentAssertions;
using Xunit;

namespace TestGreetings.NameProcessors
{
    public class DefaultNameProcessorTests
    {
        [Fact]
        public void GivenANameString_WhenProcessed_ShouldReturnUnchangedValue()
        {
            //Given
            var name = "test";
            var expectedValue = $"{localFunc()}{name}.";
            var defaultNameProcessor = new DefaultNameProcessor();

            //When
            var value = defaultNameProcessor.Process(name, localFunc);

            //Then
            value.Should().Be(expectedValue);
        }

        private string localFunc()
        {
            return "Hello, ";
        }
    }
}