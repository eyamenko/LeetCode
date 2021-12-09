namespace LeetCode.Tests;

using Xunit;

public class Problem30Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 3, 4, 5, 1, 2 }, 1 },
        new object[] { new[] { 4, 5, 6, 7, 0, 1, 2 }, 0 },
        new object[] { new[] { 11, 13, 15, 17 }, 11 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void FindMin_should_find_minimum_element(int[] nums, int expected)
    {
        var actual = Problem30.FindMin(nums);

        Assert.Equal(expected, actual);
    }
}
