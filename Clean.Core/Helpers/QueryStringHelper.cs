using Microsoft.AspNetCore.Http;

namespace Clean.Core.Helpers
{
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(IQueryCollection queryString, string key, int fallbackValue = 0)
        {
            var stringValue = queryString[key].ToString();
            if (stringValue != null && !string.IsNullOrWhiteSpace(stringValue) && int.TryParse(stringValue, out var numericValue))
            {
                return numericValue;
            }
            return fallbackValue;
        }
    }
}
