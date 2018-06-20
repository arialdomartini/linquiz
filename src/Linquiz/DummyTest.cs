using System.Collections.Generic;
using FluentAssertions;
using FluentAssertions.Collections;
using Xunit;

namespace Linquiz
{
    public class FirstQuizes
    {
        [Fact]
        public void filter_out_odd_numbers()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var result = numbers;

            result.Should().ContainInOrder(new List<int> {2, 4, 6, 8, 10});
        }

        [Fact]
        public void duplicate_list_items()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            var result = numbers;

            result.Should().ContainInOrder(new List<int> {1, 1, 2, 2, 3, 3, 4, 4, 5, 5});
        }

        [Fact]
        public void duplicate_list_items_as_pairs()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            var result = numbers;

            result.Should().ContainInOrder(new List<(int, int)> {(1, 1), (2, 2), (3, 3), (4, 4), (5, 5)});
        }

        [Fact]
        public void duplicate_a_list()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            var result = numbers;

            result.Should().ContainInOrder(new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5});
        }

        [Fact]
        public void reverse_a_list()
        {
            var numbers = new List<string> {"foo", "bar", "baz"};

            var result = numbers;

            StringCollectionAssertions stringCollectionAssertions = result.Should();
            stringCollectionAssertions.ContainInOrder(new List<string> {"baz", "bar", "foo"});
        }
    }
}