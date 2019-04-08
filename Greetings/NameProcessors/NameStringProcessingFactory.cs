using System.Collections.Generic;
namespace Greetings.NameProcessors
{
    public class NameStringProcessingFactory
    {
        public IReadOnlyCollection<INameProcessor> GetNameProcessors()
        {
            return new List<INameProcessor>{
                new NullNameProcessor(),
                new UpperCaseNameProcessor(),
                new DefaultNameProcessor()
            };
        }
    }
}