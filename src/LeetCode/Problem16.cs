namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/minimum-window-substring/">Minimum Window Substring</see>.
/// </summary>
public static class Problem16
{
    /// <summary>
    /// Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window.
    /// If there is no such substring, return the empty string "".
    /// Time complexity: O(m).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="s">String 1.</param>
    /// <param name="t">String 2.</param>
    /// <returns>Minimum window substring.</returns>
    public static string MinWindow(string s, string t)
    {
        if (s.Length < t.Length)
        {
            return string.Empty;
        }

        var (minWindowSubstring, sDict, tDict) = (string.Empty, new Dictionary<char, int>(t.Length), new Dictionary<char, int>(t.Length));

        foreach (var ch in t)
        {
            if (tDict.ContainsKey(ch))
            {
                tDict[ch]++;
            }
            else
            {
                tDict.Add(ch, 1);
            }
        }

        for (int left = 0, right = 0, count = 0; right < s.Length; right++)
        {
            if (tDict.ContainsKey(s[right]))
            {
                if (sDict.ContainsKey(s[right]))
                {
                    sDict[s[right]]++;
                }
                else
                {
                    sDict.Add(s[right], 1);
                }

                if (tDict[s[right]] == sDict[s[right]])
                {
                    count++;
                }
            }

            while (count == tDict.Count || (left <= right && !sDict.ContainsKey(s[left])))
            {
                if (sDict.ContainsKey(s[left]))
                {
                    if (tDict[s[left]] == sDict[s[left]])
                    {
                        if (minWindowSubstring.Length == 0 || right - left + 1 < minWindowSubstring.Length)
                        {
                            minWindowSubstring = s[left..(right + 1)];
                        }

                        count--;
                    }

                    sDict[s[left]]--;
                }

                if (!sDict.ContainsKey(s[left]) || sDict[s[left]] > 0 || sDict.Remove(s[left]))
                {
                    left++;
                }
            }
        }

        return minWindowSubstring;
    }
}
