using Xunit;

namespace Linquiz;

public class Inverse
{
    [Fact]
    void one_liner()
    {
        IEnumerable<int> f() => [1, 1, .. f().Zip(f().Skip(1), (a, b) => a + b)];

        Assert.Equal([1, 1, 2, 3, 5, 8, 13, 21, 34, 55], f());
    }

    [Fact]
    void with_yield()
    {
        IEnumerable<int> f()
        {
            yield return 1;
            yield return 1;

            foreach (var l in f().Zip(f().Skip(1), (a, b) => a + b))
            {
                yield return l;
            }
        }

        Assert.Equal([1, 1, 2, 3, 5, 8, 13, 21, 34, 55], f().Take(10));
    }
}