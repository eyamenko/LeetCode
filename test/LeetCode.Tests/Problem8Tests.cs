namespace LeetCode.Tests;

using Xunit;

public class Problem8Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 4, 5, 6, 7, 0 }, 0, 6 },
        new object[] { new[] { 2, 4, 5, 6, 7, 0, 1 }, 0, 5 },
        new object[] { new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4 },
        new object[] { new[] { 5, 6, 7, 0, 1, 2, 4 }, 0, 3 },
        new object[] { new[] { 6, 7, 0, 1, 2, 4, 5 }, 0, 2 },
        new object[] { new[] { 7, 0, 1, 2, 4, 5, 6 }, 0, 1 },
        new object[] { new[] { 0, 1, 2, 4, 5, 6, 7 }, 0, 0 },
        new object[] { new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1 },
        new object[] { new[] { 3, 4, 5, 6, 7, 8, 1, 2 }, 2, 7 },
        new object[] { new[] { 1 }, 0, -1 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Search_should_find_target_index(int[] nums, int target, int expected)
    {
        var actual = Problem8.Search(nums, target);

        Assert.Equal(expected, actual);
    }
}
