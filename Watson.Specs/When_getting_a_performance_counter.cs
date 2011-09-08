using System.Diagnostics;
using Machine.Specifications;
using Watson.Configuration;

namespace Watson.Specs
{
    [Subject(typeof(WatsonManager))]
    public class When_getting_a_performance_counter
    {
        Establish context = () => new FluentConfigurator()
                                        .AddCategory("Watson.Specs")
                                        .AddCounter("Tests")
                                        .CreateOrUpdate()
                                        .Initialize();

        Because of = () => _counter = WatsonManager.GetPerformanceCounter("Watson.Specs.Tests");

        It should_have_a_category_name_matching_the_namespace_part = () => _counter.CategoryName.ShouldEqual("Watson.Specs");
        It should_have_a_name_matching_the_type_name_part = () => _counter.CounterName.ShouldEqual("Tests");

        private static PerformanceCounter _counter;
    }
}