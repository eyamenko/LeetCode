namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/decode-ways/">Decode Ways</see>.
/// </summary>
public static class Problem17
{
    /// <summary>
    /// A message containing letters from A-Z can be encoded into numbers using the following mapping:
    /// 'A' -> "1".
    /// 'B' -> "2".
    /// ...
    /// 'Z' -> "26".
    /// To decode an encoded message, all the digits must be grouped then mapped back into letters using the reverse of the mapping above (there may be multiple ways).
    /// For example, "11106" can be mapped into:
    /// * "AAJF" with the grouping (1 1 10 6).
    /// * "KJF" with the grouping (11 10 6).
    /// Given a string s containing only digits, return the number of ways to decode it.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>Number of ways to decode the input string.</returns>
    public static int NumDecodings(string s)
    {
        if (s.Length == 0 || s[0] == '0')
        {
            return 0;
        }

        var second = 1;

        for (int i = 1, first = 1; i < s.Length; i++)
        {
            var count = 0;

            if (s[i - 1] != '0' && ((s[i - 1] - '0') * 10) + s[i] - '0' <= 26)
            {
                count += first;
            }

            if (s[i] != '0')
            {
                count += second;
            }

            if (count == 0)
            {
                return 0;
            }

            first = second;
            second = count;
        }

        return second;
    }
}
