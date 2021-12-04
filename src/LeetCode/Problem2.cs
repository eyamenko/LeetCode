namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-substring-without-repeating-characters/">Longest Substring Without Repeating Characters</see>.
/// </summary>
public static class Problem2
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>Length of the longest substring without repeating characters.</returns>
    public static int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;
        var set = new HashSet<char>(s.Length);

        for (int left = 0, right = 0; right < s.Length; right++)
        {
            if (!set.Add(s[right]))
            {
                while (s[left] != s[right])
                {
                    if (set.Remove(s[left]))
                    {
                        left++;
                    }
                }

                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
