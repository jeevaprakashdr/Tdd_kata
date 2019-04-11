using System.Collections.Generic;
namespace Greetings.NameProcessors
{
    public class NameStringProcessingFactory : INameStringProcessorFactory
    {
        public INameProcessor GetNameProcessors()
        {
            return new NullNameProcessor(
                new UpperCaseNameProcessor(
                    new DefaultNameProcessor()
                ));
        }
    }

    public interface INameStringProcessorFactory
    {
        INameProcessor GetNameProcessors();
    }
}