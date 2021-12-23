namespace LeetCode.Tests;

using Xunit;

public class Problem56Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 123, 321 },
        new object[] { -123, -321 },
        new object[] { 120, 21 },
        new object[] { 1534236469, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Reverse_should_reverse_integer(int x, int expected)
    {
        var actual = Problem56.Reverse(x);

        Assert.Equal(expected, actual);
    }
}
