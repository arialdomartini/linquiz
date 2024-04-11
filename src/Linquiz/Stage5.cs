using FluentAssertions;
using Xunit;

namespace Linquiz;

public class Stage5
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(14, false)]
    [InlineData(17, true)]
    void check_if_a_number_is_prime(int number, bool expected)
    {
        bool IsPrime(int n) => false;

        Assert.Equal(expected, IsPrime(number));
    }

    [Fact]
    // Reimplement Any
    void check_if_list_contains_at_least_one_item_satisfying_a_property()
    {
        int[] a = [1, 2, 3];
        int[] b = [1, 3, 5];

        bool ContainsAtLeastAnEvenNumber(IEnumerable<int> numbers) =>
            false;

        Assert.True(ContainsAtLeastAnEvenNumber(a));
        Assert.False(ContainsAtLeastAnEvenNumber(b));
    }

    [Fact]
    // Reimplement All
    void check_if_list_contains_only_items_satisfying_a_property()
    {
        int[] a = [2, 4, 6];
        int[] b = [1, 3, 5];

        bool ContainsOnlyEvenNumbers(IEnumerable<int> list) =>
            false;

        Assert.True(ContainsOnlyEvenNumbers(a));
        Assert.False(ContainsOnlyEvenNumbers(b));
    }

    [Fact]
    // Implement an improved All
    void check_if_all_the_items_satisfy_all_the_required_properties()
    {
        int[] a = [2, 4, 8];
        int[] b = [1, 4, 8];
        int[] c = [2, 4, 500];
        int[] d = [2, 6, 8];

        var rules = new Dictionary<string, Func<int, bool>>
        {
            { "is even", n => n % 2 == 0 },
            { "is not 6", n => n != 6 },
            { "is smaller than 100", n => n < 100 }
        };

        bool SatisfiesAllTheRules(IEnumerable<int> list)
        {
            return false;
        }

        SatisfiesAllTheRules(a).Should().Be(true);
        SatisfiesAllTheRules(b).Should().Be(false);
        SatisfiesAllTheRules(c).Should().Be(false);
        SatisfiesAllTheRules(d).Should().Be(false);
    }

    [Fact]
    void concatenate_lists()
    {
        int[] left = [1, 2, 3, 4];
        int[] right = [5, 6, 7];

        int[] concatenationOfLeftAndRight = [];

        Assert.Equal(
            (int[]) [1, 2, 3, 4, 5, 6, 7],
            concatenationOfLeftAndRight);
    }

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

    [Fact]
    void keep_only_matching_part_of_two_list()
    {
        int[] list1 = [5, 2, 3, 17, 19, 100, 200];
        int[] list2 = [5, 2, 3, 17, 19, 888, 300, 100];

        int[] matchingPart = [];

        Assert.Equal(
            (int[]) [5, 2, 3, 17, 19],
            matchingPart);
    }

    [Fact]
    void collect_the_non_matching_items_from_the_first_list()
    {
        int[] list1 = [5, 2, 3, 17, 19, 100, 200];
        int[] list2 = [5, 2, 3, 17, 19, 888, 300, 100];

        int[] nonMatchingPart = [];

        Assert.Equal(
            (int[]) [100, 200],
            nonMatchingPart);
    }

    [Fact]
    void collect_the_non_matching_items_from_all_the_lists()
    {
        int[] list1 = [5, 2, 3, 17, 19, 100, 200];
        int[] list2 = [5, 2, 3, 17, 19, 888, 300, 100];

        int[] allTheNonMatchingElements = [];

        Assert.Equal(
            (int[]) [100, 200, 888, 300, 100],
            allTheNonMatchingElements);
    }

    [Fact]
    void find_the_last_matching_item_in_2_lists()
    {
        int[] list1 = [5, 2, 3, 17, 19, 100, 200];
        int[] list2 = [5, 2, 3, 17, 19, 888, 300, 100];

        var lastMatchingElement = 0;

        Assert.Equal(19, lastMatchingElement);
    }
}