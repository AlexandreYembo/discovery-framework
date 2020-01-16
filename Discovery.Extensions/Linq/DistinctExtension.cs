using System;
using System.Collections.Generic;
using System.Linq;

namespace Discovery.Extensions.Linq
{
    public static class DistinctExtension 
    {
      public static IEnumerable<T> DistinctBy<T, TKey> (this IEnumerable<T> items, Func<T, TKey> property)
        {
            GeneralPropertyComparer<T, TKey> comparer = new GeneralPropertyComparer<T, TKey>(property);
            return items.Distinct(comparer);
        }   
    }
}