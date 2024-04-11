using Xunit;

namespace Linquiz;

public class Stage4
{
    [Trait("LINQ", "groupBy")]
    [Fact]
    void count_word_occurrences()
    {
        string[] words =
        [
            "baz",
            "foo",
            "bar",
            "baz",
            "foo",
            "foo",
            "qux"
        ];

        Dictionary<string, int> occurrences = new();

        Assert.Equal(
            new Dictionary<string, int>
            {
                { "foo", 3 },
                { "bar", 1 },
                { "baz", 2 },
                { "qux", 1 }
            },
            occurrences);
    }

    [Trait("LINQ", "groupBy")]
    [Fact]
    void count_word_occurrences_removing_words_that_appears_only_once()
    {
        string[] words =
        [
            "baz",
            "foo",
            "bar",
            "baz",
            "foo",
            "foo",
            "qux",
            "qux"
        ];

        Dictionary<string, int> occurrencesWithoutSingletons = new();

        Assert.Equal(
            new Dictionary<string, int>
            {
                { "foo", 3 },
                // { "bar", 1 },  // removed, as it appears only once
                { "baz", 2 },
                { "qux", 1 }
            },
            occurrencesWithoutSingletons);
    }

    [Trait("LINQ", "groupBy")]
    [Fact]
    void only_keep_items_that_have_less_than_2_occurrences()
    {
        string[] words =
        [
            "baz",
            "foo",
            "bar",
            "baz",
            "foo",
            "foo", // There are 3 occurrences of "foo". Remove all of them
            "qux"
        ];

        string[] wordsWithoutInfrequentOnes = [];

        Assert.Equal(
            (string[])
            [
                "baz",
                "bar",
                "baz",
                "qux"
            ],
            wordsWithoutInfrequentOnes);
    }

    [Trait("LINQ", "groupBy")]
    [Fact]
    void only_keep_up_to_2_occurrences_of_an_item()
    {
        string[] words =
        [
            "baz",
            "foo",
            "bar",
            "baz",
            "foo",
            "foo", // This is the 3rd "foo" occurrences. Remove it
            "qux",
            "qux",
            "qux", // 3rd and
            "qux" // 4th occurrences of "qux" must be removed
        ];

        string[] wordsWithMax2Occurrences = [];

        Assert.Equal(
            (string[])
            [
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
            ],
            wordsWithMax2Occurrences);
    }
}
