namespace Greetings.NameProcessors
{
    public class DefaultNameProcessor : INameProcessor
    {
        public string Process(string value)
        {
            return value;
        }
    }
}