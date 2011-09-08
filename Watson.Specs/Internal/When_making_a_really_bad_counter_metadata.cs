using System;
using Machine.Specifications;
using Watson.Internal;
using Watson.Specs.BCL;

namespace Watson.Specs.Internal
{
    [Subject(typeof(PerformanceCounterMetadata))]
    public class When_making_a_really_bad_counter_metadata
    {
        Because of = () => _exception = Catch.Exception(() => new PerformanceCounterMetadata(null));

        It should_throw_an_argument_null_exception = () => _exception.ShouldBeOfType<ArgumentNullException>();
        It should_indicate_the_name_parameter = () => _exception.As<ArgumentNullException>().ParamName.ShouldEqual("name");

        private static Exception _exception;
    }
}