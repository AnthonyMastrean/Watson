namespace Watson.Specs.BCL
{
    internal static class ObjectExtensions
    {
        public static T As<T>(this object obj)
        {
            return (T)obj;
        }
    }
}