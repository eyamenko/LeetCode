namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/letter-combinations-of-a-phone-number/">Letter Combinations of a Phone Number</see>.
/// </summary>
public static class Problem58
{
    private static readonly IDictionary<char, string[]> Map = new Dictionary<char, string[]>
    {
        ['2'] = new[] { "a", "b", "c" },
        ['3'] = new[] { "d", "e", "f" },
        ['4'] = new[] { "g", "h", "i" },
        ['5'] = new[] { "j", "k", "l" },
        ['6'] = new[] { "m", "n", "o" },
        ['7'] = new[] { "p", "q", "r", "s" },
        ['8'] = new[] { "t", "u", "v" },
        ['9'] = new[] { "w", "x", "y", "z" },
    };

    /// <summary>
    /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
    /// Return the answer in any order.
    /// Time complexity: O(4^n).
    /// Space complexity: O(4^n).
    /// </summary>
    /// <param name="digits">String to traverse.</param>
    /// <returns>All possible letter combinations that the number could represent.</returns>
    public static IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>(0);
        }

        return LetterCombinations(digits, digits.Length - 1).ToList();
    }

    private static IEnumerable<string> LetterCombinations(string digits, int i)
    {
        var letters = Map[digits[i]];

        if (i == 0)
        {
            foreach (var letter in letters)
            {
                yield return letter;
            }
        }
        else
        {
            foreach (var combination in LetterCombinations(digits, i - 1))
            {
                foreach (var letter in letters)
                {
                    yield return combination + letter;
                }
            }
        }
    }
}
