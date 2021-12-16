namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-repeating-character-replacement/">Longest Repeating Character Replacement</see>.
/// </summary>
public static class Problem50
{
    /// <summary>
    /// You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character.
    /// You can perform this operation at most k times.
    /// Return the length of the longest substring containing the same letter you can get after performing the above operations.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <param name="k">k.</param>
    /// <returns>Length of the longest substring containing the same letter.</returns>
    public static int CharacterReplacement(string s, int k)
    {
        var maxLength = 0;

        if (string.IsNullOrEmpty(s))
        {
            return maxLength;
        }

        var dict = new Dictionary<char, int>(26);

        for (int left = 0, right = 0, maxFrequency = 0; right < s.Length; right++)
        {
            var character = s[right];

            if (dict.ContainsKey(character))
            {
                dict[character]++;
            }
            else
            {
                dict.Add(character, 0);
            }

            maxFrequency = Math.Max(maxFrequency, dict[character]);

            while (right - left - maxFrequency > k)
            {
                dict[s[left]]--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength + 1;
    }
}
