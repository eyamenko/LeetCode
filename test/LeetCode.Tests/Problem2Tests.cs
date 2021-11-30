namespace LeetCode.Tests;

using Xunit;

public class Problem2Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "abcabcbb", 3 },
        new object[] { "bbbbb", 1 },
        new object[] { "pwwkew", 3 },
        new object[] { string.Empty, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LengthOfLongestSubstring_should_find_length_of_longest_substring_without_repeating_characters(string s, int expected)
    {
        var actual = Problem2.LengthOfLongestSubstring(s);

        Assert.Equal(expected, actual);
    }
}
