using System.Diagnostics;
using Machine.Specifications;

namespace Watson.Specs
{
    [Subject(typeof(WatsonManager))]
    public class When_getting_a_counter_for_a_new_category
    {
        Because of = () => _counter = WatsonManager.GetPerformanceCounter("Watson.Specs.Tests");

        It should_create_the_category = () => PerformanceCounterCategory.Exists("Watson.Specs").ShouldBeTrue();

        private static PerformanceCounter _counter;
    }
}