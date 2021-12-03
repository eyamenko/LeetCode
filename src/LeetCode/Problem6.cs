namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/valid-parentheses/">Valid Parentheses</see>.
/// </summary>
public static class Problem6
{
    private static readonly IDictionary<char, char> Map = new Dictionary<char, char>
    {
        ['('] = ')',
        ['{'] = '}',
        ['['] = ']',
    };

    /// <summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>True, if the input string is valid.</returns>
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>(s.Length);

        foreach (var ch in s)
        {
            if (Map.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0 || Map[stack.Pop()] != ch)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
