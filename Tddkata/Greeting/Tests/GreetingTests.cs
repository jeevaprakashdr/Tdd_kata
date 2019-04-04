using FluentAssertions;
using Xunit;

namespace Greetings.Tests
{
    public class GreetingTests
    {
        [Fact]
        public void GivenAName_WhenGreetingInterpolated_GreetingShouldBeAdded() 
        {
            // Given 
            string name = "jeeva";
            var expectedGreeting = $"Hello, {name}";
            var greeting = new Greeting();

            // When 
            var result = greeting.Greet(name);

            // Then
            result.Should().Be(expectedGreeting);
        }

        [Fact]
        public void GivenANameAllInUpperCase_WhenGreetingInterpolated_GreetingShouldBeInUpperCase()
        {
            // Given 
            string name = "JEEVA";
            var expectedGreeting = $"HELLO, {name}";
            var greeting = new Greeting();

            // When 
            var result = greeting.Greet(name);

            // Then
            result.Should().Be(expectedGreeting);
        }
    }
}
