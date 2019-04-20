using System;

namespace Greetings.NameProcessors
{
    public class NullNameProcessor : INameProcessor
    {
        private readonly INameProcessor _next;

        public NullNameProcessor(INameProcessor next)
        {
            _next = next;
        }

        public string Process(string value, Func<string> action)
        {
            if (string.IsNullOrEmpty(value))
                return $"{action()}my friend.";

            return _next.Process(value, action);
        }
    }
}