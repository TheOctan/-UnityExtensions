using System.Collections.Generic;

namespace UnityExtensions.Collections.Generic
{
    public static partial class CollectionExtensions
    {
        public static bool Empty<T>(this IReadOnlyCollection<T> collection)
        {
            return collection.Count == 0;
        }

        public static bool NotEmpty<T>(this IReadOnlyCollection<T> collection)
        {
            return collection.Count != 0;
        }

        public static bool NotContains<T>(this ICollection<T> collection, T item)
        {
            return !collection.Contains(item);
        }

        public static bool IsNotReadOnly<T>(this ICollection<T> collection)
        {
            return !collection.IsReadOnly;
        }
    }
}