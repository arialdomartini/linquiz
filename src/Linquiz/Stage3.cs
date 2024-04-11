using Xunit;

namespace Linquiz;

public class Stage3
{
    [Fact]
    void duplicate_a_list()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        int[] duplicatedList = [];

        Assert.Equal(
            (int[]) [1, 2, 3, 4, 5, 1, 2, 3, 4, 5],
            duplicatedList);
    }

    [Fact]
    void reverse_a_list()
    {
        string[] words = ["foo", "bar", "baz"];

        string[] wordsInReversedOrder = [];

        Assert.Equal(
            (string[]) ["baz", "bar", "foo"],
            wordsInReversedOrder);
    }

    [Fact]
    void reverse_a_list_using_aggregate()
    {
        string[] words = ["foo", "bar", "baz"];

        string[] wordsInReversedOrder = [];

        Assert.Equal(
            (string[]) ["baz", "bar", "foo"],
            wordsInReversedOrder);
    }

    [Fact]
    void randomly_shuffle_a_list()
    {
        int[] numbers = Enumerable.Range(1, 1000).ToArray();

        IEnumerable<int> Shuffle(IEnumerable<int> xs) => [];

        var tenResultsOfShuffling
            = Enumerable.Range(0, 10)
                .Select(_ => Shuffle(numbers.ToArray()))
                .ToArray();

        // Each result is a shuffle of the original list
        foreach (var singleShuffledResult in tenResultsOfShuffling)
        {
            AssertIsShuffled(singleShuffledResult.ToArray());
        }

        // We got 10 different results
        var asString = tenResultsOfShuffling.Select(list => string.Join("-", list)).ToArray();
        Assert.True(asString.Distinct().Count() == 10, $"Expected 10 different results but got {asString.Distinct().Count()}");

        void AssertIsShuffled(int[] shuffledNumbers)
        {
            Assert.True(numbers.Length == shuffledNumbers.Length, "Not the same length");

            foreach (var shuffledNumber in shuffledNumbers)
            {
                Assert.True(numbers.Contains(shuffledNumber), $"It does not contain the number {shuffledNumber}");
            }
        }
    }

    [Fact]
    void take_the_first_element_of_a_list()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

    [Fact]
    void take_the_first_element_of_a_list_without_using_First()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

    [Fact]
    void take_the_first_element_of_a_list_using_Aggregate()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

    [Fact]
    void take_the_second_element_of_a_list_using_Aggregate()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var secondElement = 0;

        Assert.Equal(20, secondElement);
    }

    [Fact]
    void sum_numbers_of_a_list_using_Aggregate()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        var sum = 0;

        Assert.Equal(1 + 2 + 3 + 4 + 5, sum);
    }

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
}