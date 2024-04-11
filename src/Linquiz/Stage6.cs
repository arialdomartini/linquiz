using Xunit;

namespace Linquiz;

public class Stage6
{
    [Fact]
    void take_the_central_element_of_a_list_with_an_odd_number_of_items()
    {
        int[] list = [5, 2, 3, 17, 19, 100, 200];

        int median = 0;

        Assert.Equal(17, median);
    }

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

    record Person(string Name, string Profession, int Age);
        
    [Fact]
    void build_objects_from_collection_of_properties()
    {
        // remember extract_a_single_property_from_objects ?

        var names = (string[]) ["Shansai", "Emanuele", "Protesilaos"];
        var professions = (string[]) ["Developer", "PowerPoint Architect", "Developer"];

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

    [Fact]
    void build_objects_from_a_dictionary_with_properties()
    {
        Dictionary<string, (string, int)> namesAndProfessions = new()
        {
            ["Shansai"] = ("Developer", 17),
            ["Emanuele"] = ("PowerPoint Architect", 45),
            ["Protesilaos"] = ("Developer", 40),
        };

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

    [Fact]
    void count_the_total_number_of_letters_in_all_the_sentences_both_including_and_excluding_the_spaces()
    {
        string[] words = ["one yes", "two no", "three maybe", "four"];

        (int, int) totalNumberOfLetters = (0, 0);

        Assert.Equal((28, 25), totalNumberOfLetters);
    }

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