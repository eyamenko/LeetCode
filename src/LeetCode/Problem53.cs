namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/palindromic-substrings/">Palindromic Substrings</see>.
/// </summary>
public static class Problem53
{
    /// <summary>
    /// Given a string s, return the number of palindromic substrings in it.
    /// Time complexity: O(n^2).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>Number of palindromic substrings.</returns>
    public static int CountSubstrings(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var count = 1;

        for (var i = 1; i < s.Length; i++)
        {
            count += Traverse(s, i, i) + Traverse(s, i - 1, i);
        }

        return count;
    }

    private static int Traverse(string s, int left, int right)
    {
        if (left >= 0 && right < s.Length && s[left] == s[right])
        {
            return 1 + Traverse(s, left - 1, right + 1);
        }

        return 0;
    }
}
