namespace LeetCode.Tests;

using Xunit;

public class Problem27Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "leetcode", new List<string> { "leet", "code" }, true },
        new object[] { "applepenapple", new List<string> { "apple", "pen" }, true },
        new object[] { "catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }, false },
        new object[] { "aaaaaaa", new List<string> { "aaaa", "aa" }, false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void WordBreak_should_determine_whether_input_string_can_be_segmented(string s, IList<string> wordDict, bool expected)
    {
        var actual = Problem27.WordBreak(s, wordDict);

        Assert.Equal(expected, actual);
    }
}
