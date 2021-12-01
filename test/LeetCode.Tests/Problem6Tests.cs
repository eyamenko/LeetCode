namespace LeetCode.Tests;

using Xunit;

public class Problem6Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "()", true },
        new object[] { "()[]{}", true },
        new object[] { "(]", false },
        new object[] { "([)]", false },
        new object[] { "{[]}", true },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsValid_should_check_whether_input_string_is_valid(string s, bool expected)
    {
        var actual = Problem6.IsValid(s);

        Assert.Equal(expected, actual);
    }
}
