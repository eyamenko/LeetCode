namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/implement-trie-prefix-tree/">Implement Trie (Prefix Tree)</see>.
/// </summary>
public class Problem34
{
    private readonly Problem34[] nodes;
    private bool isEnd;

    /// <summary>
    /// Initializes a new instance of the <see cref="Problem34"/> class.
    /// </summary>
    public Problem34() => this.nodes = new Problem34[26];

    /// <summary>
    /// Inserts the string `word` into the trie.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="word">Word to insert.</param>
    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            this.isEnd = true;
        }
        else
        {
            var index = GetIndex(word[0]);

            if (this.nodes[index] == null)
            {
                this.nodes[index] = new Problem34();
            }

            this.nodes[index].Insert(word[1..]);
        }
    }

    /// <summary>
    /// Returns `true` if the string `word` is in the trie (i.e., was inserted before), and `false` otherwise.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="word">Word to search.</param>
    /// <returns>True, if the word in the trie.</returns>
    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return this.isEnd;
        }
        else
        {
            var index = GetIndex(word[0]);

            if (this.nodes[index] == null)
            {
                return false;
            }

            return this.nodes[index].Search(word[1..]);
        }
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
        if (string.IsNullOrEmpty(prefix))
        {
            return true;
        }
        else
        {
            var index = GetIndex(prefix[0]);

            if (this.nodes[index] == null)
            {
                return false;
            }

            return this.nodes[index].StartsWith(prefix[1..]);
        }
    }

    private static int GetIndex(char ch) => ch - 'a';
}
