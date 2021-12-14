namespace LeetCode.Tests;

using Xunit;

public class Problem48Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 3 }, 4, 7 },
        new object[] { new[] { 9 }, 3, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CombinationSum4_should_find_number_of_possible_combinations_that_add_up_to_target(int[] nums, int target, int expected)
    {
        var actual = Problem48.CombinationSum4(nums, target);

        Assert.Equal(expected, actual);
    }
}
