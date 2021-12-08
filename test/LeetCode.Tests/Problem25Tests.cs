namespace LeetCode.Tests;

using Xunit;

public class Problem25Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 100, 4, 200, 1, 3, 2 }, 4 },
        new object[] { new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LongestConsecutive_should_find_length_of_longest_consecutive_elements_sequence(int[] nums, int expected)
    {
        var actual = Problem25.LongestConsecutive(nums);

        Assert.Equal(expected, actual);
    }
}
