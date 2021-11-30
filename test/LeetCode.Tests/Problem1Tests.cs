namespace LeetCode.Tests;

using Xunit;

public class Problem1Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { Array.Empty<int>(), 1, Array.Empty<int>() },
        new object[] { new[] { 0, 0 }, 1, Array.Empty<int>() },
        new object[] { new[] { 0, 1 }, 1, new[] { 0, 1 } },
        new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } },
        new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } },
        new object[] { new[] { 3, 3 }, 6, new[] { 0, 1 } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoSum_should_find_indices_of_two_numbers_that_add_up_to_target(int[] nums, int target, int[] expected)
    {
        var actual = Problem1.TwoSum(nums, target);

        Assert.Equal(expected, actual);
    }
}
