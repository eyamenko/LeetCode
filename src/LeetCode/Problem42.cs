namespace LeetCode;

using System.Text;

/// <summary>
/// <see href="https://leetcode.com/problems/valid-anagram/">Valid Anagram</see>.
/// </summary>
public static class Problem42
{
    /// <summary>
    /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    /// Time complexity: O(s + t).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String s.</param>
    /// <param name="t">String t.</param>
    /// <returns>True, if the second string is an anagram of the first.</returns>
    public static bool IsAnagram(string s, string t)
    {
        var sKey = GenerateKey(s);
        var tKey = GenerateKey(t);

        return sKey == tKey;
    }

    private static string GenerateKey(string str)
    {
        var alphabet = new int[26];

        foreach (var character in str)
        {
            alphabet[character - 'a']++;
        }

        var sb = new StringBuilder();

        for (var i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] != 0)
            {
                sb = sb.Append(alphabet[i]).Append((char)(i + 'a'));
            }
        }

        return sb.ToString();
    }
}
