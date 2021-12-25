namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/generate-parentheses/">Generate Parentheses</see>.
/// </summary>
public static class Problem59
{
    /// <summary>
    /// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    /// Time complexity: O(2^n).
    /// Space complexity: O(2^n).
    /// </summary>
    /// <param name="n">Number of pairs of parentheses.</param>
    /// <returns>All combinations of well-formed parentheses.</returns>
    public static IList<string> GenerateParenthesis(int n) => GenerateParenthesis("(", 1, 0, n).ToList();

    private static IEnumerable<string> GenerateParenthesis(string subCombination, int open, int close, int n)
    {
        if (close > open || open > n || close > n)
        {
            yield break;
        }

        if (open == n && close == n)
        {
            yield return subCombination;
        }

        foreach (var combination in GenerateParenthesis(subCombination + "(", open + 1, close, n))
        {
            yield return combination;
        }

        foreach (var combination in GenerateParenthesis(subCombination + ")", open, close + 1, n))
        {
            yield return combination;
        }
    }
}
