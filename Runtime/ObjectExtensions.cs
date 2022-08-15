namespace UnityExtensions
{
    public static partial class ObjectExtensions
    {
        public new static bool ReferenceEquals(this object obj, object other)
        {
            return object.ReferenceEquals(obj, other);
        }

        public static bool ReferenceNotEquals(this object obj, object other)
        {
            return !object.ReferenceEquals(obj, other);
        }
    }
}