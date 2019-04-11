using System;

namespace Greetings.NameProcessors
{
    public interface INameProcessor
    {
        string Process(string value, Func<string> GetBeginingString);
    }
}