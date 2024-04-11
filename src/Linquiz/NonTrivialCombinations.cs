using Xunit;

namespace Linquiz;

public class NonTrivialCombinations
{
    [Trait("LINQ", "non trivial combination of basics")]
    [Fact]
    void select_only_the_numbers_whose_value_is_equal_to_their_position_in_the_list()
    {
        //               0  1  2  3  4  5  6  7
        int[] numbers = [0, 1, 1, 3, 9, 9, 6, 6];

        var result = numbers;

        Assert.Equal(
            (int[]) [0, 1, 3, 6],
            result);
    }

    [Trait("LINQ", "non trivial combination of basics")]
    [Fact]
    void associate_each_items_with_its_1_based_position()
    {
        string[] words = ["one", "two", "three", "four", "five"];

        (string, int)[] itemsAndPositions = [];

        Assert.Equal(
            ((string, int)[])
            [
                ("one", 1),
                ("two", 2),
                ("three", 3),
                ("four", 4),
                ("five", 5)
            ],
            itemsAndPositions
        );
    }

    [Trait("LINQ", "non trivial combination of basics")]
    [Fact]
    void convert_numbers_to_words()
    {
        string[] words = ["zero", "one", "two", "three", "four", "five"];

        int[] numbers = [];

        Assert.Equal(
            (int[]) [1, 1, 2, 2, 1, 0, 3, 4, 1, 5],
            numbers);
    }

    [Trait("LINQ", "non trivial combination of basics")]
    [Fact]
    void remove_blacklisted_items()
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

        string[] withoutForbiddenWords = [];

        Assert.Equal(
            (string[])
            [
                "monads",
                "functors",
                "currying",
            ],
            withoutForbiddenWords);
    }
    
    [Trait("LINQ", "non trivial combination of basics")]
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

    [Trait("LINQ", "zip")]
    [Fact]
    void interleave_2_lists_items()
    {
        int[] list1 = [1, 3, 5];
        int[] list2 = [2, 4, 6];

        int[] interleavead = [];

        Assert.Equal(
            (int[]) [1, 2, 3, 4, 5, 6],
            interleavead);
    }
    
    [Trait("LINQ", "non trivial combination of basics")]
    [Fact]
    void count_the_total_number_of_letters_in_all_the_sentences_both_including_and_excluding_the_spaces()
    {
        string[] words = ["one yes", "two no", "three maybe", "four"];

        (int, int) totalNumberOfLetters = (0, 0);

        Assert.Equal((28, 25), totalNumberOfLetters);
    }
}
