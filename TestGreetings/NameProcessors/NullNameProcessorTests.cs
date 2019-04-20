using System;
using Greetings.NameProcessors;
using FluentAssertions;
using Xunit;
using Autofac.Extras.Moq;
using Moq;

namespace TestGreetings.NameProcessors
{
    public class NullNameProcessorTests
    {
        [Fact]
        public void GivenANameNull_WhenProcessed_ShouldReturnMyfriendValue()
        {
            using(var mock = AutoMock.GetLoose())
            {
                //Given
                string name = null;
                var expectedValue = "Hello, my friend.";

                mock.Mock<INameProcessor>().Setup(x => x.Process(It.Is<string>(y =>y.Equals(name)), It.IsAny<Func<string>>()));

                var nullNameProcessor = mock.Create<NullNameProcessor>();

                //When
                var value = nullNameProcessor.Process(name, localFunc);

                //Then
                value.Should().Be(expectedValue);
                mock.Mock<INameProcessor>().Verify(x =>x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()), Times.Never);
            }
        }

        [Fact]
        public void GivenANameString_WhenProcessed_ShouldInvokeNextProcessor()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Given
                string name = "test";
                var expectedValue = "Hello, my friend.";

                mock.Mock<INameProcessor>().Setup(x => x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()));

                var nullNameProcessor = mock.Create<NullNameProcessor>();

                //When
                nullNameProcessor.Process(name, localFunc);

                //Then
                mock.Mock<INameProcessor>().Verify(x => x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()), Times.Once);
            }
        }

        private string localFunc()
        {
            return "Hello, ";
        }
    }
}