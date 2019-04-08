namespace Greetings.Extensions
{
    public static class StringExtensions
    {
        public static bool IsAllInUpperCase(this string value)
        {
            foreach (var charecter in value)
            {
                if(!char.IsUpper(charecter))
                    return false;
            }
            
            return true;
        }
    }
}