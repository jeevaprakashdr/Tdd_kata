using System;
using Greetings.Extensions;
using Greetings.NameProcessors;

namespace Greetings
{
    public class Greeting
    {
        public string Greet(string name)
        {
            if(string.IsNullOrEmpty(name))
                return $"Hello, my friend.";
            
            return  name.IsAllInUpperCase() ? $"Hello, {name}.".ToUpper() : $"Hello, {name}.";
        }
    }
}