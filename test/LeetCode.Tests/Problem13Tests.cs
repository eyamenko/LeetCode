namespace LeetCode.Tests;

using Xunit;

public class Problem13Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { 1, 3 }, new[] { 6, 9 } }, new[] { 2, 5 }, new[] { new[] { 1, 5 }, new[] { 6, 9 } } },
        new object[] { new[] { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 8, 10 }, new[] { 12, 16 } }, new[] { 4, 8 }, new[] { new[] { 1, 2 }, new[] { 3, 10 }, new[] { 12, 16 } } },
        new object[] { Array.Empty<int[]>(), new[] { 5, 7 }, new[] { new[] { 5, 7 } } },
        new object[] { new[] { new[] { 1, 5 } }, new[] { 2, 3 }, new[] { new[] { 1, 5 } } },
        new object[] { new[] { new[] { 1, 5 } }, new[] { 2, 7 }, new[] { new[] { 1, 7 } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Insert_should_insert_new_interval(int[][] intervals, int[] newInterval, int[][] expected)
    {
        var actual = Problem13.Insert(intervals, newInterval);

        Assert.Equal(expected.Length, actual.Length);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
