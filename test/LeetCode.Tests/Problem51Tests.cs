namespace LeetCode.Tests;

using Xunit;

public class Problem51Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 } }, 1 },
        new object[] { new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 } }, 2 },
        new object[] { new[] { new[] { 1, 2 }, new[] { 2, 3 } }, 0 },
        new object[] { new[] { new[] { 1, 100 }, new[] { 11, 22 }, new[] { 1, 11 }, new[] { 2, 12 } }, 2 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void EraseOverlapIntervals_should_find_minimum_number_of_intervals_required_to_be_removed(int[][] intervals, int expected)
    {
        var actual = Problem51.EraseOverlapIntervals(intervals);

        Assert.Equal(expected, actual);
    }
}
