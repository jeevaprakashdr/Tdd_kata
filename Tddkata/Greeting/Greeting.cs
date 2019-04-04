using System;

namespace Greetings
{
    public class Greeting
    {
        public string Greet(string name)
        {
            if(IsAllUpper(name))
                return $"HELLO, {name}";
            return $"Hello, {name}";
        }

        private bool IsAllUpper(string input)
        {
            foreach (var item in input)
            {
                if (!Char.IsUpper(item))
                    return false;
            }

            return true;
        }
    }
}