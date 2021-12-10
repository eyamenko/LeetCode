namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/implement-trie-prefix-tree/">Implement Trie (Prefix Tree)</see>.
/// </summary>
public class Problem34
{
    private readonly TrieNode trie;

    /// <summary>
    /// Initializes a new instance of the <see cref="Problem34"/> class.
    /// </summary>
    public Problem34() => this.trie = new TrieNode();

    /// <summary>
    /// Inserts the string `word` into the trie.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="word">Word to insert.</param>
    public void Insert(string word) => this.trie.Insert(word);

    /// <summary>
    /// Returns `true` if the string `word` is in the trie (i.e., was inserted before), and `false` otherwise.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="word">Word to search.</param>
    /// <returns>True, if the word in the trie.</returns>
    public bool Search(string word)
    {
        var node = this.trie;

        foreach (var character in word)
        {
            var nextNode = node[character];

            if (nextNode == null)
            {
                return false;
            }

            node = nextNode;
        }

        return !string.IsNullOrEmpty(node.Word);
    }

    /// <summary>
    /// Returns `true` if there is a previously inserted string `word` that has the prefix `prefix`, and `false` otherwise.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="prefix">Prefix to check.</param>
    /// <returns>True, if there is the word with provided prefix.</returns>
    public bool StartsWith(string prefix)
    {
        var node = this.trie;

        foreach (var character in prefix)
        {
            var nextNode = node[character];

            if (nextNode == null)
            {
                return false;
            }

            node = nextNode;
        }

        return true;
    }
}
