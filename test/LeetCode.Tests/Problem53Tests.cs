namespace LeetCode.Tests;

using Xunit;

public class Problem53Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "abc", 3 },
        new object[] { "aaa", 6 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CountSubstrings_should_find_number_of_palindromic_substrings(string s, int expected)
    {
        var actual = Problem53.CountSubstrings(s);

        Assert.Equal(expected, actual);
    }
}
