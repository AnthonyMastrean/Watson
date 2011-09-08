using System;
using Machine.Specifications;
using Watson.Internal;
using Watson.Specs.BCL;

namespace Watson.Specs.Internal
{
    [Subject(typeof(PerformanceCounterMetadata))]
    public class When_making_a_new_counter_metadata_without_enough_names
    {
        Because of = () => _exception = Catch.Exception(() => _metadata = new PerformanceCounterMetadata("Watson"));

        It should_throw_an_argument_exception = () => _exception.ShouldBeOfType<ArgumentException>();
        It should_indicate_the_name_param = () => _exception.As<ArgumentException>().ParamName.ShouldEqual("name");
        It should_provide_some_details = () => _exception.As<ArgumentException>().Message.ShouldContain("performance counter name");

        private static PerformanceCounterMetadata _metadata;
        private static Exception _exception;
    }
}