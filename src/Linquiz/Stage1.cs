using Xunit;

namespace Linquiz
{
    public class Stage1
    {
        [Fact]
        void count_items()
        {
            string[] words = ["foo", "bar", "baz", "qox"];

            var numberOfWords = 0;

            Assert.Equal(4, numberOfWords);
        }

        [Fact]
        void count_items_using_aggregate()
        {
            string[] words = ["foo", "bar", "baz", "qox"];

            var numberOfWords = 0;

            Assert.Equal(4, numberOfWords);
        }

        [Fact]
        void convert_words_to_lowercase()
        {
            string[] words = ["WhiteFox", "TADA", "HHkb", "Corne-ish"];

            var lowerCaseWords = words;

            Assert.Equal(
                (string[]) ["whitefox", "tada", "hhkb", "corne-ish"],
                lowerCaseWords);
        }

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
        [Fact]
        void filter_out_the_strings_starting_with_the_letter_a()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var wordsNotStartingWithLetterA = words;

            Assert.Equal(
                (string[]) ["bar", "rome"],
                wordsNotStartingWithLetterA);
        }

        [Fact]
        void filter_out_the_strings_starting_with_either_the_letter_a_or_with_the_letter_r()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var wordsNotStartingWithLettersANorR = words;

            Assert.Equal(
                (string[]) ["bar"],
                wordsNotStartingWithLettersANorR);
        }

        [Fact]
        void count_strings_starting_with_the_letter_a()
        {
            string[] words = ["amsterdam", "bar", "ametista", "rome", "antelope"];

            var numberOfWordsStartingWithLetterA = 0;

            Assert.Equal(3, numberOfWordsStartingWithLetterA);
        }

        record Person(string Name, string Profession, int Age);

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

        [Fact]
        void calculate_length_of_each_word()
        {
            string[] words = ["one", "two", "three", "four"];

            int[] lengths = [];

            Assert.Equal(
                (int[]) [3, 3, 5, 4],
                lengths);
        }

        [Fact]
        void count_the_total_number_of_letters_in_all_the_words()
        {
            string[] words = ["one", "two", "three", "four"];

            var totalNumberOfLetters = 0;

            Assert.Equal(15, totalNumberOfLetters);
        }
    }
}
