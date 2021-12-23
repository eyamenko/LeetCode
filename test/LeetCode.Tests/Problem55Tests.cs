namespace LeetCode.Tests;

using Xunit;

public class Problem55Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "babad", "bab" },
        new object[] { "cbbd", "bb" },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LongestPalindrome_should_find_longest_palindromic_substring(string s, string expected)
    {
        var actual = Problem55.LongestPalindrome(s);

        Assert.Equal(expected, actual);
    }
}
