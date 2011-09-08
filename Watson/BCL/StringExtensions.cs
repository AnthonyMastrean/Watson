using System;

namespace Watson.BCL
{
    internal static class StringExtensions
    {
        public static string[] Split(this string value, char separator)
        {
            return value.Split(new[] { separator });
        }

        public static string Join(this object[] values, char separator)
        {
            return String.Join(separator.ToString(), values);
        }
    }
}