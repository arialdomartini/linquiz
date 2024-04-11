using FluentAssertions;
using Xunit;

namespace Linquiz
{
    public class FirstQuizes
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

        [Fact]
        void count_the_total_number_of_letters_in_all_the_sentences_excluding_the_spaces()
        {
            string[] words = ["one yes", "two no", "three maybe", "four"];

            var totalNumberOfLetters = 0;

            Assert.Equal(25, totalNumberOfLetters);
        }

        [Fact]
        void filter_out_odd_numbers()
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            int[] evenNumbers = [];

            Assert.Equal(
                (int[]) [2, 4, 6, 8, 10],
                evenNumbers);
        }

        [Fact]
        void count_numbers_smaller_than_5()
        {
            int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

            var numberOfNumbersSmallerThan5 = 0;

            Assert.Equal(4, numberOfNumbersSmallerThan5);
        }

        [Fact]
        void count_even_numbers_smaller_than_5()
        {
            int[] numbers = [10, 11, 2, 3, 100, 4, 1, 2];

            var numberOfEvenNumbersSmallerThan5 = 0;

            Assert.Equal(3, numberOfEvenNumbersSmallerThan5);
        }

        [Fact]
        void select_only_the_numbers_whose_value_is_equal_to_their_position_in_the_list()
        {
            //               0  1  2  3  4  5  6  7
            int[] numbers = [0, 1, 1, 3, 9, 9, 6, 6];

            var result = numbers;

            Assert.Equal(
                (int[]) [0, 1, 3, 6],
                result);
        }

        [Fact]
        void associate_each_items_with_its_1_based_position()
        {
            string[] words = ["one", "two", "three", "four", "five"];

            (string, int)[] itemsAndPositions = [];

            Assert.Equal(
                ((string, int)[])
                [
                    ("one", 1),
                    ("two", 2),
                    ("three", 3),
                    ("four", 4),
                    ("five", 5)
                ],
                itemsAndPositions
            );
        }

        [Fact]
        void convert_numbers_to_words()
        {
            string[] words = ["zero", "one", "two", "three", "four", "five"];

            int[] numbers = [];

            Assert.Equal(
                (int[]) [1, 1, 2, 2, 1, 0, 3, 4, 1, 5],
                numbers);
        }

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

        [Fact]
        void duplicate_list_items_as_pairs()
        {
            int[] numbers = [1, 2, 3, 4, 5];

            (int, int)[] duplicatedPairs = [];

            Assert.Equal(
                ((int, int)[]) [(1, 1), (2, 2), (3, 3), (4, 4), (5, 5)],
                duplicatedPairs);
        }

        [Fact]
        void duplicate_list_items()
        {
            int[] numbers = [10, 2, 30, 4, 5];

            int[] duplicatedElements = [];

            Assert.Equal(
                (int[]) [10, 10, 2, 2, 30, 30, 4, 4, 5, 5],
                duplicatedElements);
        }

        [Fact]
        void duplicate_a_list()
        {
            int[] numbers = [1, 2, 3, 4, 5];

            int[] duplicatedList = [];

            Assert.Equal(
                (int[]) [1, 2, 3, 4, 5, 1, 2, 3, 4, 5],
                duplicatedList);
        }

        [Fact]
        void reverse_a_list()
        {
            string[] words = ["foo", "bar", "baz"];

            string[] wordsInReversedOrder = [];

            Assert.Equal(
                (string[]) ["baz", "bar", "foo"],
                wordsInReversedOrder);
        }

        [Fact]
        void reverse_a_list_using_aggregate()
        {
            string[] words = ["foo", "bar", "baz"];

            string[] wordsInReversedOrder = [];

            Assert.Equal(
                (string[]) ["baz", "bar", "foo"],
                wordsInReversedOrder);
        }

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

        [Fact]
        void take_the_first_element_of_a_list()
        {
            int[] numbers = [10, 20, 30, 40, 50];

            var firstElement = 0;

            Assert.Equal(10, firstElement);
        }

        [Fact]
        void take_the_first_element_of_a_list_without_using_First()
        {
            int[] numbers = [10, 20, 30, 40, 50];

            var firstElement = 0;

            Assert.Equal(10, firstElement);
        }


        [Fact]
        void take_the_first_element_of_a_list_using_Aggregate()
        {
            int[] numbers = [10, 20, 30, 40, 50];

            var firstElement = 0;

            Assert.Equal(10, firstElement);
        }

        [Fact]
        void take_the_second_element_of_a_list_using_Aggregate()
        {
            int[] numbers = [10, 20, 30, 40, 50];

            var secondElement = 0;

            Assert.Equal(20, secondElement);
        }

        [Fact]
        void sum_numbers_of_a_list_using_Aggregate()
        {
            int[] numbers = [1, 2, 3, 4, 5];

            var sum = 0;

            Assert.Equal(1 + 2 + 3 + 4 + 5, sum);
        }

        [Fact]
        void remove_blacklisted_items()
        {
            string[] words =
            [
                "monads",
                "functors",
                "side effects",
                "currying",
                "duplication",
                "duplication",
                "mutability"
            ];

            string[] forbiddenWords =
            [
                "mutability",
                "side effects",
                "duplication"
            ];

            string[] withoutForbiddenWords = [];

            Assert.Equal(
                (string[])
                [
                    "monads",
                    "functors",
                    "currying",
                ],
                withoutForbiddenWords);
        }

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

        [Fact]
        void concatenate_strings_skipping_blacklisted_words()
        {
            string[] words =
            [
                "monads",
                "functors",
                "side effects",
                "currying",
                "duplication",
                "duplication",
                "mutability"
            ];

            string[] forbiddenWords =
            [
                "mutability",
                "side effects",
                "duplication"
            ];

            string allTheGoodWords = "";

            Assert.Equal(
                "monads, functors, currying",
                allTheGoodWords);
        }

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

        [Fact]
        void count_word_occurrences()
        {
            string[] words =
            [
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",
                "qux"
            ];

            Dictionary<string, int> occurrences = new();

            Assert.Equal(
                new Dictionary<string, int>
                {
                    { "foo", 3 },
                    { "bar", 1 },
                    { "baz", 2 },
                    { "qux", 1 }
                },
                occurrences);
        }

        [Fact]
        void count_word_occurrences_removing_words_that_appears_only_once()
        {
            string[] words =
            [
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo",
                "qux",
                "qux"
            ];

            Dictionary<string, int> occurrencesWithoutSingletons = new();

            Assert.Equal(
                new Dictionary<string, int>
                {
                    { "foo", 3 },
                    // { "bar", 1 },  // removed, as it appears only once
                    { "baz", 2 },
                    { "qux", 1 }
                },
                occurrencesWithoutSingletons);
        }

        [Fact]
        void only_keep_items_that_have_less_than_2_occurrences()
        {
            string[] words =
            [
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo", // There are 3 occurrences of "foo". Remove all of them
                "qux"
            ];

            string[] wordsWithoutInfrequentOnes = [];

            Assert.Equal(
                (string[])
                [
                    "baz",
                    "bar",
                    "baz",
                    "qux"
                ],
                wordsWithoutInfrequentOnes);
        }

        [Fact]
        void only_keep_up_to_2_occurrences_of_an_item()
        {
            string[] words =
            [
                "baz",
                "foo",
                "bar",
                "baz",
                "foo",
                "foo", // This is the 3rd "foo" occurrences. Remove it
                "qux",
                "qux",
                "qux", // 3rd and
                "qux" // 4th occurrences of "qux" must be removed
            ];

            string[] wordsWithMax2Occurrences = [];

            Assert.Equal(
                (string[])
                [
                    "baz",
                    "foo",
                    "bar",
                    "baz",
                    "foo",
                    // "foo",
                    "qux",
                    "qux",
                    // "qux",
                    // "qux"
                ],
                wordsWithMax2Occurrences);
        }

        [Fact]
        void zip_lists()
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

            var result = people;

            Assert.Equal(
                (string[])
                [
                    "Thierry drinks water",
                    "Arialdo drinks Martini dry",
                    "Emanuele drinks water"
                ],
                result);
        }

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

        [Fact]
        void find_all_possible_couples()
        {
            int[] numbers = [1, 2, 3];

            (int, int)[] allPossibleCouples = [];

            Assert.Equal(((int, int)[])
                [
                    (1, 1),
                    (1, 2),
                    (1, 3),

                    (2, 1),
                    (2, 2),
                    (2, 3),

                    (3, 1),
                    (3, 2),
                    (3, 3)
                ],
                allPossibleCouples);
        }

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

        [Fact]
        void take_the_central_element_of_a_list_with_an_odd_number_of_items()
        {
            int[] list = [ 5, 2, 3, 17, 19, 100, 200 ];

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
}
