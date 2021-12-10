namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/word-search-ii/">Word Search II</see>.
/// </summary>
public static class Problem35
{
    /// <summary>
    /// Given an m x n board of characters and a list of strings words, return all words on the board.
    /// Each word must be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring.
    /// The same letter cell may not be used more than once in a word.
    /// Time complexity: O(m * n * w).
    /// Space complexity: O(w).
    /// </summary>
    /// <param name="board">Array to traverse.</param>
    /// <param name="words">Words to find.</param>
    /// <returns>All words on the board.</returns>
    public static IList<string> FindWords(char[][] board, string[] words)
    {
        var result = new List<string>();
        var trie = new TrieNode();

        foreach (var word in words)
        {
            trie.Insert(word);
        }

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                Traverse(board, i, j, trie, trie, result);
            }
        }

        return result;
    }

    private static void Traverse(char[][] board, int i, int j, TrieNode trie, TrieNode node, IList<string> result)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] == '*')
        {
            return;
        }

        var character = board[i][j];
        var nextNode = node[character];

        if (nextNode == null)
        {
            return;
        }

        if (!string.IsNullOrEmpty(nextNode.Word))
        {
            result.Add(nextNode.Word);
            trie.Remove(nextNode.Word);
        }

        board[i][j] = '*';

        Traverse(board, i + 1, j, trie, nextNode, result);
        Traverse(board, i - 1, j, trie, nextNode, result);
        Traverse(board, i, j + 1, trie, nextNode, result);
        Traverse(board, i, j - 1, trie, nextNode, result);

        board[i][j] = character;
    }
}
