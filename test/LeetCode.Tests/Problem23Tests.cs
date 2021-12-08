namespace LeetCode.Tests;

using Xunit;

public class Problem23Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 7, 1, 5, 3, 6, 4 }, 5 },
        new object[] { new[] { 7, 6, 4, 3, 1 }, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxProfit_should_find_maximum_possible_profit(int[] prices, int expected)
    {
        var actual = Problem23.MaxProfit(prices);

        Assert.Equal(expected, actual);
    }
}
