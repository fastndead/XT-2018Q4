using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK5.ISeekYou
{

    public static class Search
    {
        public static IEnumerable<T> Searcher<T>(this T[] array, Func<T, bool> condition)
        {
            foreach (var item in array)
            {
                if (condition(item))
                {
                    yield return item;
                }
            }
        }

    }
}