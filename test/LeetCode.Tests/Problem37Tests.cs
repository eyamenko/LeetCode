namespace LeetCode.Tests;

using Xunit;

public class Problem37Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 3, 1 }, true },
        new object[] { new[] { 1, 2, 3, 4 }, false },
        new object[] { new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ContainsDuplicate_should_indicate_if_any_value_appears_at_least_twice(int[] nums, bool expected)
    {
        var actual = Problem37.ContainsDuplicate(nums);

        Assert.Equal(expected, actual);
    }
}
