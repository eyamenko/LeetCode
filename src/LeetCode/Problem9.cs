namespace LeetCode;

using System.Text;

/// <summary>
/// <see href="https://leetcode.com/problems/group-anagrams/">Group Anagrams</see>.
/// </summary>
public static class Problem9
{
    /// <summary>
    /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="strs">Array to traverse.</param>
    /// <returns>Grouped anagrams.</returns>
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>(strs.Length);

        foreach (var str in strs)
        {
            var key = GenerateKey(str);

            if (dict.ContainsKey(key))
            {
                dict[key].Add(str);
            }
            else
            {
                dict.Add(key, new List<string> { str });
            }
        }

        return dict.Values.ToList();
    }

    private static string GenerateKey(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }

        var alphabet = new int[26];

        foreach (var ch in str)
        {
            alphabet[ch - 'a']++;
        }

        var sb = new StringBuilder();

        for (var i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] > 0)
            {
                sb = sb.Append(alphabet[i]).Append((char)(i + 'a'));
            }
        }

        return sb.ToString();
    }
}
