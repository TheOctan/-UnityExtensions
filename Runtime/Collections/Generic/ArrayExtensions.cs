namespace UnityExtensions.Collections.Generic
{
    public static partial class ArrayExtensions
    {
        public static bool Empty<T>(this T[] array)
        {
            return array.Length == 0;
        }

        public static bool NotEmpty<T>(this T[] array)
        {
            return array.Length != 0;
        }
    }
}