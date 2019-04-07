using Greetings;
using FluentAssertions;
using Xunit;
namespace TestGreetings
{
    public class GreetingsTests
    {
        [Fact]
        public void GivenAName_WhenIGreet_ThenShouldReturnNameWithGreetings()
        {
            //Given
            var name = "jeeva";

            //When
            var greeting = new Greeting();
            var nameWithGreeting = greeting.Greet(name);

            //Then
            nameWithGreeting.Should().Be($"Hello, {name}.");
        }
    }
}