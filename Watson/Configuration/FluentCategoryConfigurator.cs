using System.Diagnostics;

namespace Watson.Configuration
{
    public class FluentCategoryConfigurator
    {
        private readonly string _name;
        private readonly string _help;
        private readonly PerformanceCounterCategoryType _type;
        private readonly CounterCreationDataCollection _counters 
            = new CounterCreationDataCollection();

        private readonly FluentConfigurator _parent;

        public FluentCategoryConfigurator(
            string name, 
            string help, 
            PerformanceCounterCategoryType type, 
            FluentConfigurator parent)
        {
            _name = name;
            _help = help;
            _type = type;
            _parent = parent;
        }

        public FluentCategoryConfigurator AddCounter(
            string name, 
            string help = "", 
            PerformanceCounterType type = PerformanceCounterType.NumberOfItems32)
        {
            _counters.Add(new CounterCreationData(name, help, type));
            return this;
        }

        public FluentConfigurator CreateOrUpdate()
        {
            return _parent;
        }

        internal void Initialize()
        {
            if(PerformanceCounterCategory.Exists(_name))
                PerformanceCounterCategory.Delete(_name);
            
            PerformanceCounterCategory.Create(_name, _help, _type, _counters);
        }
    }
}