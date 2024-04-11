using Xunit;

namespace Linquiz;

public class Stage2
{
    [Fact]
    void count_the_total_number_of_letters_in_all_the_sentences_excluding_the_spaces()
    {
        string[] words = ["one yes", "two no", "three maybe", "four"];

        var totalNumberOfLetters = 0;

        Assert.Equal(25, totalNumberOfLetters);
    }

    [Fact]
    void filter_out_odd_numbers()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        int[] evenNumbers = [];

        Assert.Equal(
            (int[]) [2, 4, 6, 8, 10],
            evenNumbers);
    }

    [Fact]
    void count_numbers_smaller_than_5()
    {
        int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

        var numberOfNumbersSmallerThan5 = 0;

        Assert.Equal(4, numberOfNumbersSmallerThan5);
    }

    [Fact]
    void count_even_numbers_smaller_than_5()
    {
        int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

        var numberOfEvenNumbersSmallerThan5 = 0;

        Assert.Equal(3, numberOfEvenNumbersSmallerThan5);
    }

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

    [Fact]
    void convert_numbers_to_words()
    {
        string[] words = ["zero", "one", "two", "three", "four", "five"];

        int[] numbers = [];

        Assert.Equal(
            (int[]) [1, 1, 2, 2, 1, 0, 3, 4, 1, 5],
            numbers);
    }

    [Fact]
    void swap_items_in_tuples()
    {
        (string, int)[] numbers =
        [
            ("one", 1),
            ("two", 2),
            ("three", 3),
            ("four", 4),
            ("five", 5)
        ];

        (int, string)[] swappedTuples = [];

        Assert.Equal(
            ((int, string)[])
            [
                (1, "one"),
                (2, "two"),
                (3, "three"),
                (4, "four"),
                (5, "five")
            ],
            swappedTuples
        );
    }

    [Fact]
    void duplicate_list_items_as_pairs()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        (int, int)[] duplicatedPairs = [];

        Assert.Equal(
            ((int, int)[]) [(1, 1), (2, 2), (3, 3), (4, 4), (5, 5)],
            duplicatedPairs);
    }

    [Fact]
    void duplicate_list_items()
    {
        int[] numbers = [10, 2, 30, 4, 5];

        int[] duplicatedElements = [];

        Assert.Equal(
            (int[]) [10, 10, 2, 2, 30, 30, 4, 4, 5, 5],
            duplicatedElements);
    }
}