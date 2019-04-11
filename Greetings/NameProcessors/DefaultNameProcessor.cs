using System;

namespace Greetings.NameProcessors
{
    public class DefaultNameProcessor : INameProcessor
    {
        public string Process(string value, Func<string> action)
        {
            return $"{action()}{value}.";
        }
    }
}