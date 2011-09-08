using System.Diagnostics;
using System.Linq;
using Machine.Specifications;

namespace Watson.Specs
{
    [Subject(typeof(WatsonManager))]
    public class When_using_a_performance_counter
    {
        Establish context = () => _counter = WatsonManager.GetPerformanceCounter("Watson.Specs.Tests");

        Because of = () => Enumerable.Range(0, 3).ToList().ForEach(_ => _counter.Increment());

        It should_be_writable = () => _counter.RawValue.ShouldBeGreaterThan(1);

        private static PerformanceCounter _counter;
    }
}