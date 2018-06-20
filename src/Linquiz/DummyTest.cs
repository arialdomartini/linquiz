using System.Collections.Generic;
using System.Linq;
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
        
        [Fact]
        public void randomly_shuffle_a_list()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            IEnumerable<int> Shuffle(IEnumerable<int> list)
            {
                // Implement here
                return list;
            }

            var results = Enumerable.Range(0, 100)
                .Select(i => Shuffle(numbers))
                .Distinct()
                .ToList();

            results.Count.Should().BeGreaterThan(1);

            results.ForEach(r => r.Should().BeEquivalentTo(numbers));
        }

        [Fact]
        public void sum_numbers_of_a_list()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            var result = 0;

            result.Should().Be(15);
        }

        [Fact]
        public void sum_numbers_of_a_list_using_Aggregate()
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};

            var result = 0;

            result.Should().Be(15);
        }

        [Fact]
        public void remove_blacklisted_items()
        {
            var words = new List<string>
            {
                "foo",
                "bar",
                "forbidden",
                "baz",
                "skipme",
                "qux"
            };

            var forbiddenWords = new List<string>
                {"skipme", "forbidden"};

            var result = words;

            result.Should().ContainInOrder(new List<string>
            {
                "foo",
                "bar",
                "baz",
                "qux"
            });
        }

        [Fact]
        public void concatenate_strings_skipping_blacklisted_words()
        {
            var words = new List<string>
            {
                "foo",
                "bar",
                "forbidden",
                "baz",
                "skipme",
                "qux"
            };

            var forbiddenWords = new List<string>
                {"skipme", "forbidden"};

            var result = "";

            result.Should().Be("foobarbazqux");
        }

        [Fact]
        public void reverse_words_in_a_list()
        {
            var words = new List<string>
            {
                "foo",
                "bar",
                "baz",
                "qux"
            };

            var result = words;

            result.Should().ContainInOrder(new List<string>
            {
                "oof",
                "rab",
                "zab",
                "xuq"
            });
        }

        [Fact]
        public void count_word_occourrences()
        {
            var words = new List<string>
            {
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",
                "qux"
            };

            var result = new Dictionary<string, int>();

            result.Should().BeEquivalentTo(new Dictionary<string, int>
            {
                {"foo", 3},
                {"bar", 1},
                {"baz", 2},
                {"qux", 1}
            });
        }
        [Fact]
        public void count_word_occourrences_removing_words_that_appears_only_once()
        {
            var words = new List<string>
            {
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",
                "qux",
                "qux"
            };

            var result = new Dictionary<string, int>();

            result.Should().BeEquivalentTo(new Dictionary<string, int>
            {
                {"foo", 3},
                // {"bar", 1},  // removed, as it appears only once
                {"baz", 2},
                {"qux", 2}
            });
        }

        [Fact]
        public void only_keep_items_that_have_less_than_2_occourrences()
        {
            var words = new List<string>
            {
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",  // There are 3 occourrences of "foo". Remove all of them
                "qux"
            };

            var result = words;

            result.Should().ContainInOrder(new List<string>
            {
                "baz",
                "bar",
                "baz",
                "qux"
            });
        }
        [Fact]
        public void only_keep_up_to_2_occourrences_of_an_item()
        {
            var words = new List<string>
            {
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",  // This is the 3rd "foo" occourrences. Remove it
                "qux",
                "qux",
                "qux", // 3rd and
                "qux"  // 4th occourrences of "qux" must be removed
            };

            var result = words;

            result.Should().ContainInOrder(new List<string>
            {
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                // "foo",
                "qux",
                "qux",
                // "qux",
                // "qux"
            });
        }
    }
}