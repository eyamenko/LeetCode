namespace LeetCode.Tests;

using Xunit;

public class Problem10Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 },
        new object[] { new[] { 1 }, 1 },
        new object[] { new[] { 5, 4, -1, 7, 8 }, 23 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxSubArray_should_find_largest_subarray_sum(int[] nums, int expected)
    {
        var actual = Problem10.MaxSubArray(nums);

        Assert.Equal(expected, actual);
    }
}
