namespace LeetCode.Tests;

using Xunit;

public class Problem35Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { 'o', 'a', 'a', 'n' }, new[] { 'e', 't', 'a', 'e' }, new[] { 'i', 'h', 'k', 'r' }, new[] { 'i', 'f', 'l', 'v' } }, new[] { "oath", "pea", "eat", "rain" }, new[] { "oath", "eat" } },
        new object[] { new[] { new[] { 'a', 'b' }, new[] { 'c', 'd' } }, new[] { "abcb" }, Array.Empty<string>() },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void FindWords_should_find_all_words_on_board(char[][] board, string[] words, string[] expected)
    {
        var actual = Problem35.FindWords(board, words);

        Assert.Equal(expected, actual);
    }
}
