namespace LeetCode.Tests;

using Xunit;

public class Problem36Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 2, 3, 2 }, 3 },
        new object[] { new[] { 1, 2, 3, 1 }, 4 },
        new object[] { new[] { 1, 2, 3 }, 3 },
        new object[] { new[] { 200, 3, 140, 20, 10 }, 340 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Rob_should_find_maximum_amount_of_money_that_can_be_robbed(int[] nums, int expected)
    {
        var actual = Problem36.Rob(nums);

        Assert.Equal(expected, actual);
    }
}
