namespace LeetCode.Tests;

using Xunit;

public class Problem45Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4 },
        new object[] { new[] { 0, 1, 0, 3, 2, 3 }, 4 },
        new object[] { new[] { 7, 7, 7, 7, 7, 7, 7 }, 1 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LengthOfLIS_should_find_length_of_longest_strictly_increasing_subsequence(int[] nums, int expected)
    {
        var actual = Problem45.LengthOfLIS(nums);

        Assert.Equal(expected, actual);
    }
}
