using Xunit;

namespace Linquiz;

public class Native
{
    [Trait("LINQ", "native")]
    [Fact]
    void count_items()
    {
        string[] words = ["foo", "bar", "baz", "qox"];

        var numberOfWords = 0;

        Assert.Equal(4, numberOfWords);
    }
    
    [Trait("LINQ", "native")]
    [Fact]
    void duplicate_list_items()
    {
        int[] numbers = [10, 2, 30, 4, 5];

        int[] duplicatedElements = [];

        Assert.Equal(
            (int[]) [10, 10, 2, 2, 30, 30, 4, 4, 5, 5],
            duplicatedElements);
    }
    
    [Trait("LINQ", "native")]
    [Fact]
    void duplicate_a_whole_list()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        int[] duplicatedList = [];

        Assert.Equal(
            (int[]) [1, 2, 3, 4, 5, 1, 2, 3, 4, 5],
            duplicatedList);
    }
    
    [Trait("LINQ", "native")]
    [Fact]
    void take_the_first_element_of_a_list()
    {
        int[] numbers = [10, 20, 30, 40, 50];

        var firstElement = 0;

        Assert.Equal(10, firstElement);
    }

}
