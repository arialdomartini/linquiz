using Xunit;

namespace Linquiz;

public class CombinationOfBasics
{
    [Trait("LINQ", "combination of basics")]
    [Fact]
    void count_the_total_number_of_letters_in_all_the_words()
    {
        string[] words = ["one", "two", "three", "four"];

        var totalNumberOfLetters = 0;

        Assert.Equal(15, totalNumberOfLetters);
    }

    [Trait("LINQ", "combination of basics")]
    [Fact]
    void count_strings_starting_with_the_letter_a()
    {
        string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

        var numberOfWordsStartingWithLetterA = 0;

        Assert.Equal(3, numberOfWordsStartingWithLetterA);
    }
    
    [Trait("LINQ", "combination of basics")]
    [Fact]
    void count_the_total_number_of_letters_in_all_the_sentences_excluding_the_spaces()
    {
        string[] words = ["one yes", "two no", "three maybe", "four"];

        var totalNumberOfLetters = 0;

        Assert.Equal(25, totalNumberOfLetters);
    }

    [Trait("LINQ", "combination of basics")]
    [Fact]
    void count_numbers_smaller_than_5()
    {
        int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

        var numberOfNumbersSmallerThan5 = 0;

        Assert.Equal(4, numberOfNumbersSmallerThan5);
    }

    [Trait("LINQ", "combination of basics")]
    [Fact]
    void count_even_numbers_smaller_than_5()
    {
        int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

        var numberOfEvenNumbersSmallerThan5 = 0;

        Assert.Equal(3, numberOfEvenNumbersSmallerThan5);
    }

}
