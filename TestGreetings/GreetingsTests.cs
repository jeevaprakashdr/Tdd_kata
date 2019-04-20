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
            nameWithGreeting.Should().Be($"Hello,{name}.");
        }

        [Fact]
        public void GivenANameValueAsNull_WhenIGreet_ThenShouldReturnCustomeGreeting()
        {
            //Given
            string name = null;

            //When
            var greeting = new Greeting();
            var nameWithGreeting = greeting.Greet(name);

            //Then
            nameWithGreeting.Should().Be($"Hello,my friend.");
        }

        [Fact]
        public void GivenANameInUpperCase_WhenIGreet_ThenShouldReturnGreetingsInUpperCase()
        {
            //Given
            var name = "jeeva".ToUpper();

            //When
            var greeting = new Greeting();
            var nameWithGreeting = greeting.Greet(name);

            //Then
            nameWithGreeting.Should().Be($"Hello,{name}.".ToUpper());
        }
    }
}