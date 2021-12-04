namespace LeetCode.Tests;

using Xunit;

public class Problem15Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 2, 2 },
        new object[] { 3, 3 },
        new object[] { 4, 5 },
        new object[] { 5, 8 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ClimbStairs_should_find_number_of_distinct_ways_to_reach_top(int n, int expected)
    {
        var actual = Problem15.ClimbStairs(n);

        Assert.Equal(expected, actual);
    }
}
