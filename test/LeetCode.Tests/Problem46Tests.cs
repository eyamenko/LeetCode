namespace LeetCode.Tests;

using Xunit;

public class Problem46Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 5 }, 11, 3 },
        new object[] { new[] { 2 }, 3, -1 },
        new object[] { new[] { 1 }, 0, 0 },
        new object[] { new[] { 1 }, 1, 1 },
        new object[] { new[] { 1 }, 2, 2 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CoinChange_should_find_fewest_number_of_coins_that_is_needed_to_make_up_the_amount(int[] coins, int amount, int expected)
    {
        var actual = Problem46.CoinChange(coins, amount);

        Assert.Equal(expected, actual);
    }
}
