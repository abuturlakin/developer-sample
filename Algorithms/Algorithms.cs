using System;
using System.Linq;
using DeveloperSample.Algorithms.Extensions;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            var result = 1;
            for (var i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items.HasNoValue())
                return string.Empty;

            if (items.HasOnlyOneValue())
                return items.First();
            
            var lastItem = items.Last();
            var itemsExceptLast = items.Except(new [] { lastItem }).ToArray();
            var commaSeparatedList = string.Join(", ", itemsExceptLast);
            return $"{commaSeparatedList} and {lastItem}";
        }
    }
}