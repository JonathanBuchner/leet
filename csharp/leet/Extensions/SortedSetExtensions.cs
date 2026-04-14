using System.Collections.Generic;

#nullable enable
public static class SortedSetExtensions
{
    public static T? Predecessor<T>(this SortedSet<T> set, T value) where T : notnull
    {
        T? result = default;

        foreach (T item in set)
        {
            if (Comparer<T>.Default.Compare(item, value) >= 0)
                break;

            result = item;
        }

        return result;
    }

    public static T? Successor<T>(this SortedSet<T> set, T value) where T : notnull
    {
        foreach (T item in set)
        {
            if (Comparer<T>.Default.Compare(item, value) > 0)
                return item;
        }

        return default;
    }
}