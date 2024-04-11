using Xunit;

namespace Linquiz;

public class Aggregate
{
    [Trait("LINQ", "aggregate")]
    [Fact]
    void count_items_using_aggregate()
    {
        string[] words = ["foo", "bar", "baz", "qox"];

        var numberOfWords = 0;

        Assert.Equal(4, numberOfWords);
    }

    [Trait("LINQ", "aggregate")]
    [Fact]
    void sum_numbers_of_a_list_using_Aggregate()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        var sum = 0;

        Assert.Equal(1 + 2 + 3 + 4 + 5, sum);
    }

    [Trait("LINQ", "aggregate")]
    [Fact]
    void take_the_first_element_of_a_list_without_using_First()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

    [Trait("LINQ", "aggregate")]
    [Fact]
    void take_the_first_element_of_a_list_using_Aggregate()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

    [Trait("LINQ", "aggregate")]
    [Fact]
    void take_the_second_element_of_a_list_using_Aggregate()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var secondElement = 0;

        Assert.Equal(20, secondElement);
    }

    [Trait("LINQ", "aggregate")]
    [Fact]
    void reverse_a_list_using_aggregate()
    {
        string[] words = ["foo", "bar", "baz"];

        string[] wordsInReversedOrder = [];

        Assert.Equal(
            (string[]) ["baz", "bar", "foo"],
            wordsInReversedOrder);
    }
}
