using Xunit;

namespace Linquiz;

public class Monads
{
    [Trait("LINQ", "selectMany")]
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
}