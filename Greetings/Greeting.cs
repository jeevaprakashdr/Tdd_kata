using Greetings.NameProcessors;

namespace Greetings
{
    public class Greeting
    {
        private readonly INameStringProcessorFactory _factory;
        public Greeting()
        {
            _factory = new NameStringProcessingFactory();
        }

        public string Greet(string name)
        {
            var processor = _factory.GetNameProcessors();
            return  processor.Process(name, () =>{ return "Hello, ";});
        }
    }
}