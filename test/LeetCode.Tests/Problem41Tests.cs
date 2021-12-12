namespace LeetCode.Tests;

using Xunit;

public class Problem41Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 } },
        new object[] { new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ProductExceptSelf_should_produce_product_of_array_except_self(int[] nums, int[] expected)
    {
        var actual = Problem41.ProductExceptSelf(nums);

        Assert.Equal(expected, actual);
    }
}
