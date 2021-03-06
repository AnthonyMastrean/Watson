﻿using System.Diagnostics;
using Machine.Specifications;
using Watson.Configuration;

namespace Watson.Specs.Configuration
{
    [Subject(typeof(FluentConfigurator))]
    public class When_configuring_a_new_category_with_counters
    {
        It should_create_the_category = () => PerformanceCounterCategory.Exists("Watson.Specs").ShouldBeTrue();
        It should_create_the_counter = () => PerformanceCounterCategory.CounterExists("Tests", "Watson.Specs").ShouldBeTrue();
    }
}