using Xunit;

namespace Linquiz;

public class FreeStyle
{
    [Trait("LINQ", "free-style")]
    [Fact]
    void reverse_a_list()
    {
        string[] words = ["foo", "bar", "baz"];

        string[] wordsInReversedOrder = [];

        Assert.Equal(
            (string[]) ["baz", "bar", "foo"],
            wordsInReversedOrder);
    }

    [Trait("LINQ", "free-style")]
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

    [Trait("LINQ", "free-style")]
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

    [Trait("LINQ", "free-style")]
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

    [Trait("LINQ", "free-style")]
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

    [Trait("LINQ", "free-style")]
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

    [Trait("LINQ", "free-style")]
    [Fact]
    void find_the_last_matching_item_in_2_lists()
    {
        int[] list1 = [5, 2, 3, 17, 19, 100, 200];
        int[] list2 = [5, 2, 3, 17, 19, 888, 300, 100];

        var lastMatchingElement = 0;

        Assert.Equal(19, lastMatchingElement);
    }

    [Trait("LINQ", "free-style")]
    [Trait("LINQ", "group-by")]
    [Fact]
    void take_the_central_element_of_a_list_with_an_odd_number_of_items()
    {
        int[] list = [5, 2, 3, 17, 19, 100, 200];

        int median = 0;

        Assert.Equal(17, median);
    }

    [Trait("LINQ", "free-style")]
    [Trait("LINQ", "group-by")]
    [Fact]
    void split_odd_and_even_numbers()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        (int[], int[]) splitNumbers = ([], []);

        Assert.Equal(
            (
                (int[]) [1, 3, 5, 7, 9],
                (int[]) [2, 4, 6, 8, 10]),
            splitNumbers);
    }

    record PersonWithoutAge(string Name, string Profession);

    [Trait("LINQ", "free-style")]
    [Fact]
    void build_objects_from_collections_of_properties()
    {
        // remember extract_a_single_property_from_objects ?

        var names = (string[]) ["Shansai", "Emanuele", "Protesilaos"];
        var professions = (string[]) ["Developer", "PowerPoint Architect", "Developer"];

        PersonWithoutAge[] people = [];

        Assert.Equal(
            (PersonWithoutAge[])
            [
                new PersonWithoutAge(Name: "Shansai", Profession: "Developer"),
                new PersonWithoutAge(Name: "Emanuele", Profession: "PowerPoint Architect"),
                new PersonWithoutAge(Name: "Protesilaos", Profession: "Developer"),
            ],
            people);
    }

    record Person(string Name, string Profession, int Age);

    [Trait("LINQ", "free-style")]
    [Fact]
    void build_objects_from_3_collections_of_properties()
    {
        var names = (string[]) ["Shansai", "Emanuele", "Protesilaos"];
        var professions = (string[]) ["Developer", "PowerPoint Architect", "Developer"];
        var ages = (int[]) [17, 45, 40];

        Person[] people = [];

        Assert.Equal(
            (Person[])
            [
                new Person(Name: "Shansai", Profession: "Developer", Age: 17),
                new Person(Name: "Emanuele", Profession: "PowerPoint Architect", Age: 45),
                new Person(Name: "Protesilaos", Profession: "Developer", Age: 40),
            ],
            people);
    }


    [Trait("LINQ", "free-style")]
    [Fact]
    void select_only_the_numbers_whose_value_is_equal_to_their_position_either_in_the_list_or_in_the_reversed_list()
    {
        //               0  1  2  3  4  5  6  7
        int[] numbers = [0, 1, 5, 3, 9, 1, 6, 6];
        //               0  1  2  3  4  5  6  7
        //   reversed = [6, 6, 1, 9, 3, 5, 1, 0];


        int[] result = numbers;

        Assert.Equal(
            (int[]) [0, 1, 5, 3, 6],
            result);
    }

    [Trait("LINQ", "free-style")]
    [Fact]
    void associate_list_items_with_previous_item()
    {
        const int defaultValue = 99;
        int[] numbers = [1, 2, 3, 4, 5];

        (int, int)[] associated = [];

        Assert.Equal(
            ((int, int)[]) [(1, 99), (2, 1), (3, 2), (4, 3), (5, 4)],
            associated);
    }

    [Trait("LINQ", "free-style")]
    [Fact]
    void associate_list_items_with_next_item()
    {
        const int defaultValue = 99;
        int[] numbers = [1, 2, 3, 4, 5];

        (int, int)[] associated = [];

        Assert.Equal(
            ((int, int)[]) [(1, 2), (2, 3), (3, 4), (4, 5), (5, 99)],
            associated);
    }
}
