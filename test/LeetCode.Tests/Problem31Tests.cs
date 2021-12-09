namespace LeetCode.Tests;

using Xunit;

public class Problem31Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 3, 1 }, 4 },
        new object[] { new[] { 2, 7, 9, 3, 1 }, 12 },
        new object[] { new[] { 2, 1, 1, 2 }, 4 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Rob_should_find_maximum_amount_of_money(int[] nums, int expected)
    {
        var actual = Problem31.Rob(nums);

        Assert.Equal(expected, actual);
    }
}
