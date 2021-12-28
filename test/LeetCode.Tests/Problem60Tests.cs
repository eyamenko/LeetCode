namespace LeetCode.Tests;

using Xunit;

public class Problem60Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 10, 3, 3 },
        new object[] { 7, -3, -2 },
        new object[] { -2147483648, 2, -1073741824 },
        new object[] { 2147483647, 1, 2147483647 },
        new object[] { -231, 3, -77 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Divide_should_calculate_quotient_after_dividing_dividend_by_divisor(int dividend, int divisor, int expected)
    {
        var actual = Problem60.Divide(dividend, divisor);

        Assert.Equal(expected, actual);
    }
}
