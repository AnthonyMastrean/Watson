using Machine.Specifications;
using Watson.Internal;

namespace Watson.Specs.Internal
{
    [Subject(typeof(PerformanceCounterMetadata))]
    public class When_making_a_new_counter_metadata
    {
        Because of = () => _metadata = new PerformanceCounterMetadata("Watson.Specs.Tests");

        It should_parse_the_namespace_part_as_the_category_name = () => _metadata.CategoryName.ShouldEqual("Watson.Specs");
        It should_parse_the_type_name_part_as_the_counter_name = () => _metadata.CounterName.ShouldEqual("Tests");

        private static PerformanceCounterMetadata _metadata;
    }
}