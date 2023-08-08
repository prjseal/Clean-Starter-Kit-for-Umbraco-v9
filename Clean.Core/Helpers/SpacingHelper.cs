using System.Collections.Generic;
using System.Linq;

namespace Clean.Core.Helpers
{
    public static class SpacingHelper
    {
        public static string GetSpacingClasses(string paddingTop, string paddingBottom, string paddingLeft, string paddingRight, string marginTop, string marginBottom, string marginLeft, string marginRight)
        {
            var classList = new List<string>();
            classList.Add(GetClassIfNotEmpty("pt-", paddingTop));
            classList.Add(GetClassIfNotEmpty("pb-", paddingBottom));
            classList.Add(GetClassIfNotEmpty("ps-", paddingLeft));
            classList.Add(GetClassIfNotEmpty("pe-", paddingRight));
            classList.Add(GetClassIfNotEmpty("mt-", marginTop));
            classList.Add(GetClassIfNotEmpty("mb-", marginBottom));
            classList.Add(GetClassIfNotEmpty("ms-", marginLeft));
            classList.Add(GetClassIfNotEmpty("me-", marginRight));
            return string.Join(" ", classList.Where(x => !string.IsNullOrWhiteSpace(x)));
        }

        private static string GetClassIfNotEmpty(string prefix, string value)
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                return prefix + value;
            }
            return "";
        }
    }
}
