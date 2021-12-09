namespace LeetCode.Tests;

using Xunit;

public class Problem29Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 2, 3, -2, 4 }, 6 },
        new object[] { new[] { -2, 0, -1 }, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxProduct_should_find_largest_product_of_subarray(int[] nums, int expected)
    {
        var actual = Problem29.MaxProduct(nums);

        Assert.Equal(expected, actual);
    }
}
