namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/word-break/">Word Break</see>.
/// </summary>
public static class Problem27
{
    /// <summary>
    /// Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.
    /// Note that the same word in the dictionary may be reused multiple times in the segmentation.
    /// Time complexity: O(s^2 + n).
    /// Space complexity: O(s + n).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <param name="wordDict">Word dictionary.</param>
    /// <returns>True, if the input string can be segmented.</returns>
    public static bool WordBreak(string s, IList<string> wordDict)
    {
        var wordDictSet = new HashSet<string>(wordDict.Count);

        for (var i = 0; i < wordDict.Count; i++)
        {
#pragma warning disable IDE0058
            wordDictSet.Add(wordDict[i]);
#pragma warning restore IDE0058
        }

        return Traverse(s, 0, new bool[s.Length], wordDictSet);
    }

    private static bool Traverse(string s, int i, bool[] wordBreaks, ISet<string> wordDictSet)
    {
        if (i >= s.Length)
        {
            return true;
        }

        if (wordBreaks[i])
        {
            return false;
        }

        for (int left = i, right = Math.Min(left + 20, s.Length); left < right; left++)
        {
            if (wordDictSet.Contains(s[i..(left + 1)]))
            {
                wordBreaks[i] = true;

                if (Traverse(s, left + 1, wordBreaks, wordDictSet))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
