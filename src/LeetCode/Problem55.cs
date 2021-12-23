namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-palindromic-substring/">Longest Palindromic Substring</see>.
/// </summary>
public static class Problem55
{
    /// <summary>
    /// Given a string s, return the longest palindromic substring in s.
    /// Time complexity: O(n^2).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>Longest palindromic substring.</returns>
    public static string LongestPalindrome(string s)
    {
        var (maxLeft, maxRight) = (0, 0);

        for (var i = 1; i < s.Length; i++)
        {
            (maxLeft, maxRight) = LongestPalindromeWindow(s, i - 1, i, maxLeft, maxRight);
            (maxLeft, maxRight) = LongestPalindromeWindow(s, i - 1, i + 1, maxLeft, maxRight);
        }

        return s[maxLeft..(maxRight + 1)];
    }

    private static (int MaxLeft, int MaxRight) LongestPalindromeWindow(string s, int left, int right, int maxLeft, int maxRight)
    {
        for (; left >= 0 && right < s.Length && s[left] == s[right]; left--, right++)
        {
            if (right - left > maxRight - maxLeft)
            {
                (maxLeft, maxRight) = (left, right);
            }
        }

        return (maxLeft, maxRight);
    }
}
