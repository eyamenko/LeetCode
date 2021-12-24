namespace LeetCode.Tests;

using Xunit;

public class Problem57Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "42", 42 },
        new object[] { "   -42", -42 },
        new object[] { "4193 with words", 4193 },
        new object[] { "words and 987", 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MyAtoi_should_convert_string_to_integer(string s, int expected)
    {
        var actual = Problem57.MyAtoi(s);

        Assert.Equal(expected, actual);
    }
}
