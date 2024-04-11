using Xunit;

namespace Linquiz
{
    public class Basic
    {
        [Trait("LINQ", "select")]
        [Fact]
        void convert_words_to_lowercase()
        {
            string[] words = ["WhiteFox", "TADA", "HHkb", "Corne-ish"];

            var lowerCaseWords = words;

            Assert.Equal(
                (string[]) ["whitefox", "tada", "hhkb", "corne-ish"],
                lowerCaseWords);
        }

        [Trait("LINQ", "where")]
        [Fact]
        void select_only_the_strings_starting_with_the_letter_a()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var wordsStartingWithLetterA = words;

            Assert.Equal(
                (string[]) ["amsterdam", "ametista", "antelope"],
                wordsStartingWithLetterA);
        }

        // TODO get both: starting and not starting
        // TODO group by initial letter
        [Trait("LINQ", "where")]
        [Fact]
        void filter_out_the_strings_starting_with_the_letter_a()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var wordsNotStartingWithLetterA = words;

            Assert.Equal(
                (string[]) ["bar", "rome"],
                wordsNotStartingWithLetterA);
        }

        [Trait("LINQ", "where")]
        [Fact]
        void filter_out_the_strings_starting_with_either_the_letter_a_or_with_the_letter_r()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var wordsNotStartingWithLettersANorR = words;

            Assert.Equal(
                (string[]) ["bar"],
                wordsNotStartingWithLettersANorR);
        }
 
        [Trait("LINQ", "where")]
        [Fact]
        void filter_out_odd_numbers()
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            int[] evenNumbers = [];

            Assert.Equal(
                (int[]) [2, 4, 6, 8, 10],
                evenNumbers);
        }
        
        record Person(string Name, string Profession, int Age);

        [Trait("LINQ", "select")]
        [Fact]
        void extract_a_single_property_from_objects()
        {
            Person[] people =
            [
                new Person(Name: "Shansai", Profession: "Developer", Age: 17),
                new Person(Name: "Emanuele", Profession: "PowerPoint Architect", Age: 45),
                new Person(Name: "Protesilaos", Profession: "Developer", Age: 40),
            ];

            string[] names = [];

            Assert.Equal(
                (string[]) ["Shansai", "Emanuele", "Protesilaos"],
                names);
        }

        [Trait("LINQ", "select")]
        [Fact]
        void calculate_length_of_each_word_without()
        {
            string[] words = ["one", "two", "three", "four"];

            int[] lengths = [];

            Assert.Equal(
                (int[]) [3, 3, 5, 4],
                lengths);
        }
        
        [Trait("LINQ", "select")]
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

        [Trait("LINQ", "select")]
        [Fact]
        void duplicate_list_items_as_pairs()
        {
            int[] numbers = [1, 2, 3, 4, 5];

            (int, int)[] duplicatedPairs = [];

            Assert.Equal(
                ((int, int)[]) [(1, 1), (2, 2), (3, 3), (4, 4), (5, 5)],
                duplicatedPairs);
        }
        
        [Trait("LINQ", "select")]
        [Fact]
        void reverse_words_in_a_list()
        {
            string[] words =
            [
                "foo",
                "bar",
                "baz",
                "qux"
            ];

            string[] reversedWords = [];

            Assert.Equal(
                (string[])
                [
                    "oof",
                    "rab",
                    "zab",
                    "xuq"
                ],
                reversedWords);
        }
        
        [Trait("LINQ", "select")]
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

    }
}
