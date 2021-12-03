namespace LeetCode.Tests;

using Xunit;

public class Problem12Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } }, new[] { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } } },
        new object[] { new[] { new[] { 1, 4 }, new[] { 4, 5 } }, new[] { new[] { 1, 5 } } },
        new object[] { new[] { new[] { 1, 4 }, new[] { 0, 2 }, new[] { 3, 5 } }, new[] { new[] { 0, 5 } } },
        new object[] { new[] { new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 }, new[] { 8, 9 }, new[] { 1, 10 } }, new[] { new[] { 1, 10 } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Merge_should_merge_overlapping_intervals(int[][] intervals, int[][] expected)
    {
        var actual = Problem12.Merge(intervals);

        Assert.Equal(expected.Length, actual.Length);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
