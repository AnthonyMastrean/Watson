using System;
using System.Linq;

namespace Watson
{
    public class PerformanceCounterMetadata
    {
        public string CounterName { get; private set; }
        public string CategoryName { get; private set; }

        public PerformanceCounterMetadata(string name)
        {
            if(name == null)
                throw new ArgumentNullException("name");

            var tokens = name.Split(Separator.Namespace);
            
            if(tokens.Length < 2)
                throw new ArgumentException("The performance counter name should have a category and a counter name part. Something like 'Watson.Specs.Tests', where 'Watson.Specs' is the category name and 'Tests' is the counter name", "name");

            CounterName = tokens.Last();
            CategoryName = tokens.Take(tokens.Length - 1).ToArray().Join(Separator.Namespace);
        }
    }
}