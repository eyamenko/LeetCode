namespace LeetCode.Tests;

using Xunit;

public class Problem42Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "anagram", "nagaram", true },
        new object[] { "rat", "car", false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsAnagram_should_determine_whether_second_string_is_anagram_of_first(string s, string t, bool expected)
    {
        var actual = Problem42.IsAnagram(s, t);

        Assert.Equal(expected, actual);
    }
}
