namespace LeetCode.Tests;

using Xunit;

public class Problem34Tests
{
    private readonly Problem34 trie;

    public Problem34Tests()
    {
        this.trie = new Problem34();

        this.trie.Insert("apple");
    }

    [Theory]
    [InlineData("apple", true)]
    [InlineData("app", false)]
    public void Search_should_find_word_if_its_in_trie(string word, bool expected) => Assert.Equal(expected, this.trie.Search(word));

    [Theory]
    [InlineData("app", true)]
    [InlineData("aff", false)]
    public void StartsWith_should_check_if_there_is_word_with_provided_prefix(string prefix, bool expected) => Assert.Equal(expected, this.trie.StartsWith(prefix));
}
