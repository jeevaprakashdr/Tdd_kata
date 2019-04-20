using System;
using Greetings.NameProcessors;
using FluentAssertions;
using Xunit;
using Autofac.Extras.Moq;
using Moq;

namespace TestGreetings.NameProcessors
{
    public class UpperCaseNameProcessorTests
    {
        [Fact]
        public void GivenANameIsUpperCase_WhenProcessed_ShouldReturnValueInUpperCase()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Given
                string name = "JEEVA";
                var expectedValue = "HELLO, JEEVA.";

                mock.Mock<INameProcessor>().Setup(x => x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()));

                var upperCaseNameProcessor = mock.Create<UpperCaseNameProcessor>();

                //When
                var value = upperCaseNameProcessor.Process(name, localFunc);

                //Then
                value.Should().Be(expectedValue);
                mock.Mock<INameProcessor>().Verify(x => x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()), Times.Never);
            }
        }

        [Fact]
        public void GivenANameString_WhenProcessed_ShouldInvokeNextProcessor()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Given
                string name = "test";
               
                mock.Mock<INameProcessor>().Setup(x => x.Process(It.Is<string>(y => y.Equals(name)), It.IsAny<Func<string>>()));

                var upperCaseNameProcessor = mock.Create<UpperCaseNameProcessor>();

                //When
                upperCaseNameProcessor.Process(name, localFunc);

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