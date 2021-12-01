namespace LeetCode.Tests;

using Xunit;

public class Problem9Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { "eat", "tea", "tan", "ate", "nat", "bat" }, new[] { new[] { "eat", "tea", "ate" }, new[] { "tan", "nat" }, new[] { "bat" } } },
        new object[] { new[] { string.Empty }, new[] { new[] { string.Empty } } },
        new object[] { new[] { "a" }, new[] { new[] { "a" } } },
        new object[] { new[] { "bdddddddddd", "bbbbbbbbbbc" }, new[] { new[] { "bdddddddddd" }, new[] { "bbbbbbbbbbc" } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void GroupAnagrams_should_group_anagrams(string[] strs, string[][] expected)
    {
        var actual = Problem9.GroupAnagrams(strs);

        Assert.Equal(expected.Length, actual.Count);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
