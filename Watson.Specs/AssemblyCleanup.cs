using System.Diagnostics;
using Machine.Specifications;
using Watson.Configuration;

namespace Watson.Specs
{
    public class AssemblyCleanup : IAssemblyContext
    {
        public void OnAssemblyStart()
        {
            new FluentConfigurator()
                .AddCategory("Watson.Specs")
                .AddCounter("Tests")
                .AddCounter("Exceptions")
                .CreateOrUpdate()
                .Initialize();
        }

        public void OnAssemblyComplete()
        {
            PerformanceCounterCategory.Delete("Watson.Specs");
        }
    }
}