using System.Diagnostics;
using Machine.Specifications;

namespace Watson.Specs
{
    public class AssemblyCleanup : IAssemblyContext
    {
        public void OnAssemblyStart()
        {
        }

        public void OnAssemblyComplete()
        {
            PerformanceCounterCategory.Delete("Watson.Specs");
        }
    }
}