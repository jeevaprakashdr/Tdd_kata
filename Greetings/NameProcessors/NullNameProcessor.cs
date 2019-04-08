namespace Greetings.NameProcessors
{
    public class NullNameProcessor : INameProcessor
    {
        public string Process(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "my friend.";

            return value;
        }
    }
}