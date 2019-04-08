using Greetings.Extensions;
namespace Greetings.NameProcessors
{
    public class UpperCaseNameProcessor : INameProcessor
    {
        public string Process(string value)
        {
            if (value.IsAllInUpperCase())
                return value.ToUpper();

            return value;
        }
    }
}