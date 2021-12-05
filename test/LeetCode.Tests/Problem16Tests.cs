namespace LeetCode.Tests;

using Xunit;

public class Problem16Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "ADOBECODEBANC", "ABC", "BANC" },
        new object[] { "a", "a", "a" },
        new object[] { "a", "aa", string.Empty },
        new object[] { "ab", "b", "b" },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MinWindow_should_find_minimum_window_substring(string s, string t, string expected)
    {
        var actual = Problem16.MinWindow(s, t);

        Assert.Equal(expected, actual);
    }
}
