using Xunit;

namespace Linquiz;

public class Stage4
{
    [Fact]
    void intersections_of_sets()
    {
        string[] allTheTopics =
        [
            "y-combinator",
            "monads",
            "functors",
            "currying",
            "yoneda lemma"
        ];

        string[] hardTopics =
        [
            "yoneda lemma",
            "monads",
            "y-combinator",
            "being punctual"
        ];

        string[] intersection = [];

        Assert.Equal(
            (string[])
            [
                "monads",
                "yoneda lemma",
                "y-combinator",
            ],
            intersection);
    }

    [Fact]
    void concatenate_strings_skipping_blacklisted_words()
    {
        string[] words =
        [
            "monads",
            "functors",
            "side effects",
            "currying",
            "duplication",
            "duplication",
            "mutability"
        ];

        string[] forbiddenWords =
        [
            "mutability",
            "side effects",
            "duplication"
        ];

        string allTheGoodWords = "";

        Assert.Equal(
            "monads, functors, currying",
            allTheGoodWords);
    }

    [Fact]
    void reverse_words_in_a_list()
    {
        string[] words =
        [
            "foo",
            "bar",
            "baz",
            "qux"
        ];

        string[] reversedWords = [];

        Assert.Equal(
            (string[])
            [
                "oof",
                "rab",
                "zab",
                "xuq"
            ],
            reversedWords);
    }

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

    [Fact]
    void zip_lists()
    {
        string[] people =
        [
            "Thierry",
            "Arialdo",
            "Emanuele",
        ];

        string[] drinks =
        [
            "water",
            "Martini dry",
            "water"
        ];

        var result = people;

        Assert.Equal(
            (string[])
            [
                "Thierry drinks water",
                "Arialdo drinks Martini dry",
                "Emanuele drinks water"
            ],
            result);
    }

    [Fact]
    void multiply_numbers_from_2_lists()
    {
        int[] numbers1 = [2, 3, 4];
        int[] numbers2 = [10, 100, 1000];

        int[] products = [];

        Assert.Equal(
            (int[])
            [
                2 * 10,
                3 * 100,
                4 * 100
            ],
            products);
    }

    [Fact]
    void find_all_possible_couples()
    {
        int[] numbers = [1, 2, 3];

        (int, int)[] allPossibleCouples = [];

        Assert.Equal(((int, int)[])
            [
                (1, 1),
                (1, 2),
                (1, 3),

                (2, 1),
                (2, 2),
                (2, 3),

                (3, 1),
                (3, 2),
                (3, 3)
            ],
            allPossibleCouples);
    }
}