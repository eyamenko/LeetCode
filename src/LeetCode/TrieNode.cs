namespace LeetCode;

/// <summary>
/// Trie node.
/// </summary>
public class TrieNode
{
    private readonly TrieNode?[] nodes;

    /// <summary>
    /// Initializes a new instance of the <see cref="TrieNode"/> class.
    /// </summary>
    public TrieNode() => this.nodes = new TrieNode?[26];

    /// <summary>
    /// Gets word.
    /// </summary>
    public string? Word { get; private set; }

    /// <summary>
    /// Gets trie node.
    /// </summary>
    /// <param name="characterCode">Character code.</param>
    /// <returns>Trie node, if it exists.</returns>
    public TrieNode? this[int characterCode]
    {
        get
        {
            var index = GetIndex(characterCode);

            return this.nodes[index];
        }
    }

    /// <summary>
    /// Inserts the word into the trie.
    /// </summary>
    /// <param name="word">Word to insert.</param>
    public void Insert(string word)
    {
        var node = this;

        foreach (var character in word)
        {
            var index = GetIndex(character);

            node = node.nodes[index] ??= new TrieNode();
        }

        node.Word = word;
    }

    /// <summary>
    /// Removes the word from the trie.
    /// </summary>
    /// <param name="word">Word to remove.</param>
    public void Remove(string word)
    {
#pragma warning disable IDE0022
        this.Remove(word, 0);
#pragma warning restore IDE0022
    }

    private static int GetIndex(int characterCode) => characterCode - 'a';

    private bool Remove(string word, int characterIndex)
    {
        if (characterIndex < word.Length)
        {
            var index = GetIndex(word[characterIndex]);
            var nextNode = this.nodes[index];

            if (nextNode == null || !nextNode.Remove(word, characterIndex + 1))
            {
                return false;
            }

            this.nodes[index] = null;
        }
        else
        {
            this.Word = null;
        }

        foreach (var node in this.nodes)
        {
            if (node != null)
            {
                return false;
            }
        }

        return true;
    }
}
