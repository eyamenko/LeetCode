namespace LeetCode.Tests;

using Xunit;

public class Problem11Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 0, 1 }, false },
        new object[] { new[] { 0 }, true },
        new object[] { new[] { 2, 3, 1, 1, 4 }, true },
        new object[] { new[] { 3, 2, 1, 0, 4 }, false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CanJump_should_indicate_whether_last_index_can_be_reached(int[] nums, bool expected)
    {
        var actual = Problem11.CanJump(nums);

        Assert.Equal(expected, actual);
    }
}
