using System.Collections.Concurrent;
using System.Diagnostics;

namespace Watson.Configuration
{
    public class FluentConfigurator
    {
        private readonly ConcurrentDictionary<string, FluentCategoryConfigurator> _map 
            = new ConcurrentDictionary<string, FluentCategoryConfigurator>();

        public FluentCategoryConfigurator AddCategory(
            string name, 
            string help = "", 
            PerformanceCounterCategoryType type = PerformanceCounterCategoryType.SingleInstance)
        {
            return _map.GetOrAdd(name, new FluentCategoryConfigurator(name, help, type, this));
        }

        public void Initialize()
        {
            foreach(var configurator in _map.Values)
            {
                configurator.Initialize();
            }
        }
    }
}