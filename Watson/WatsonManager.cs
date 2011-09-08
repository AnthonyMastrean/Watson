using System.Diagnostics;
using Watson.Internal;

namespace Watson
{
    public static class WatsonManager
    {
        public static PerformanceCounter GetPerformanceCounter(string name)
        {
            var metadata = new PerformanceCounterMetadata(name);

            return new PerformanceCounter(
                metadata.CategoryName, 
                metadata.CounterName,
                false);
        }
    }
}