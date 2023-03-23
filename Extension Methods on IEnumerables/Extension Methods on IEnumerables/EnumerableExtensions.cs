namespace Extension_Methods_on_IEnumerables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static bool CustomAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CustomAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static T CustomMax<T>(this IEnumerable<T> source, Func<T, T, int> comparer)
        {
            T max = source.FirstOrDefault();
            foreach (var item in source.Skip(1))
            {
                if (comparer(max, item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T CustomMin<T>(this IEnumerable<T> source, Func<T, T, int> comparer)
        {
            T min = source.FirstOrDefault();
            foreach (var item in source.Skip(1))
            {
                if (comparer(min, item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
