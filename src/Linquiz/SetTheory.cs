using Xunit;

namespace Linquiz;

public class SetTheory
{
    [Trait("LINQ", "set theory")]
    [Fact]
    void intersections_of_sets()
    {
        string[] allTheTopics =
        [
            "y-combinator",
            "monads",
            "functors",
            "currying",
            "yoneda lemma"
        ];

        string[] hardTopics =
        [
            "yoneda lemma",
            "monads",
            "y-combinator",
            "being punctual"
        ];

        string[] intersection = [];

        Assert.Equal(
            (string[])
            [
                "monads",
                "yoneda lemma",
                "y-combinator",
            ],
            intersection);
    }

    [Trait("LINQ", "set theory")]
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
    
    [Trait("LINQ", "zip")]
    [Trait("LINQ", "set theory")]
    [Fact]
    void product_of_sets()
    {
        string[] people =
        [
            "Thierry",
            "Arialdo",
            "Emanuele",
        ];

        string[] drinks =
        [
            "water",
            "Martini dry",
            "water"
        ];

        (string, string)[] result = [];

        Assert.Equal(
            ((string, string)[])
            [
                ("Thierry", "water"),
                ("Arialdo", "Martini dry"),
                ("Emanuele", "water")
            ],
            result);
    }

    [Trait("LINQ", "zip")]
    [Trait("LINQ", "set theory")]
    [Fact]
    void zip_lists_as_strings()
    {
        string[] people =
        [
            "Thierry",
            "Arialdo",
            "Emanuele",
        ];

        string[] drinks =
        [
            "water",
            "Martini dry",
            "water"
        ];

        string[] sentences = [];

        Assert.Equal(
            (string[])
            [
                "Thierry drinks water",
                "Arialdo drinks Martini dry",
                "Emanuele drinks water"
            ],
            sentences);
    }

    [Trait("LINQ", "zip")]
    [Trait("LINQ", "set theory")]
    [Fact]
    void multiply_numbers_from_2_lists()
    {
        int[] numbers1 = [2, 3, 4];
        int[] numbers2 = [10, 100, 1000];

        int[] products = [];

        Assert.Equal(
            (int[])
            [
                2 * 10,
                3 * 100,
                4 * 100
            ],
            products);
    }
}
