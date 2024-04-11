using Xunit;

namespace Linquiz;

public class Reimplementation
{
    [Trait("LINQ", "reimplementation")]
    [Fact]
    void duplicate_a_list_reimplementing_concatenate()
    {
        int[] numbers = [10, 2, 30, 4, 5];

        int[] duplicatedElements = [];

        Assert.Equal(
            (int[]) [10, 10, 2, 2, 30, 30, 4, 4, 5, 5],
            duplicatedElements);
    }
    
    [Trait("LINQ", "reimplementation")]
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

    [Trait("LINQ", "reimplementation")]
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

    [Trait("LINQ", "reimplementation")]
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

        Assert.True(SatisfiesAllTheRules(a));
        Assert.False(SatisfiesAllTheRules(b));
        Assert.False(SatisfiesAllTheRules(c));
        Assert.False(SatisfiesAllTheRules(d));
    }

    [Trait("LINQ", "reimplementation")]
    [Fact]
    void implement_Where_using_Aggregate()
    {
        bool IsEven(int n) => n % 2 == 0;
        bool IsNot35(int n) => n != 35;

        int[] numbers = [5, 20, 35, 40, 50];

        int[] Where(int[] xs, Func<int, bool> predicate) => [];

        Assert.Equal(
            numbers.Where(IsEven),
            Where(numbers, IsEven));

        Assert.Equal(
            numbers.Where(IsNot35),
            Where(numbers, IsNot35));
    }

    [Trait("LINQ", "reimplementation")]
    [Fact]
    void implement_Select_using_Aggregate()
    {
        int Plus1(int n) => n + 1;
        int Twice(int n) => n * 2;

        int[] numbers = [5, 20, 35, 40, 50];

        int[] Select(int[] xs, Func<int, int> f) => [];

        Assert.Equal(
            numbers.Select(Plus1),
            Select(numbers, Plus1));

        Assert.Equal(
            numbers.Select(Twice),
            Select(numbers, Twice));
    }

    [Trait("LINQ", "reimplementation")]
    [Fact]
    void implement_Select_using_Aggregate_as_a_generic_function()
    {
        string AsAString(int n) => n.ToString();
        int Twice(int n) => n * 2;

        int[] numbers = [5, 20, 35, 40, 50];

        IEnumerable<B> Select<A, B>(IEnumerable<A> xs, Func<A, B> f) => [];

        Assert.Equal(
            numbers.Select(AsAString),
            Select(numbers, AsAString));

        Assert.Equal(
            numbers.Select(Twice),
            Select(numbers, Twice));
    }
}
