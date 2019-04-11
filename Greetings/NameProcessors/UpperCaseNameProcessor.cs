using System;
using Greetings.Extensions;
namespace Greetings.NameProcessors
{
    public class UpperCaseNameProcessor : INameProcessor
    {
        private readonly INameProcessor _next;

        public UpperCaseNameProcessor(INameProcessor next)
        {
            _next = next;
        }

        public string Process(string value, Func<string> action)
        {
            if (value.IsAllInUpperCase())
                return $"{action()}{value}.".ToUpper();

            return _next.Process(value, action);
        }
    }
}