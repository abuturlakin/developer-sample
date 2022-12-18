using System.Collections.Generic;
using System.Linq;

namespace DeveloperSample.Algorithms.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool HasValue<T>(this IEnumerable<T> items)
        {
            return items != null && items.Count() > 0;
        }
        
        public static bool HasNoValue<T>(this IEnumerable<T> items)
        {
            return !items.HasValue();
        }
        
        public static bool HasOnlyOneValue<T>(this IEnumerable<T> items)
        {
            return items != null && items.Count() == 1;
        }
    }    
}