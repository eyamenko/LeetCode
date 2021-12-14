namespace LeetCode.Tests;

using Xunit;

public class Problem47Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 } },
        new object[] { new[] { 1, 2 }, 1, new[] { 1 } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void TopKFrequent_should_find_k_most_frequent_elements(int[] nums, int k, int[] expected)
    {
        var actual = Problem47.TopKFrequent(nums, k);

        Assert.Equal(expected, actual);
    }
}
