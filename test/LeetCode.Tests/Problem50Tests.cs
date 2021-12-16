namespace LeetCode.Tests;

using Xunit;

public class Problem50Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "ABAB", 2, 4 },
        new object[] { "AABABBA", 1, 4 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CharacterReplacement_should_find_length_of_longest_substring_containing_same_letter(string s, int k, int expected)
    {
        var actual = Problem50.CharacterReplacement(s, k);

        Assert.Equal(expected, actual);
    }
}
