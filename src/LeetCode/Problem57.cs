namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/string-to-integer-atoi/">String to Integer (atoi)</see>.
/// </summary>
public static class Problem57
{
    /// <summary>
    /// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="s">String to traverse.</param>
    /// <returns>Converted integer.</returns>
    public static int MyAtoi(string s)
    {
        var (i, converted) = (0, 0);

        for (; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                break;
            }
        }

        if (i >= s.Length)
        {
            return converted;
        }

        var isPositive = s[i] != '-';

        if (s[i] == '+' || !isPositive)
        {
            i++;
        }

        for (; i < s.Length; i++)
        {
            var digit = s[i] - '0';

            if (digit is < 0 or > 9)
            {
                break;
            }

            try
            {
                checked
                {
                    converted *= 10;
                    converted += digit;
                }
            }
            catch (OverflowException)
            {
                return isPositive ? int.MaxValue : int.MinValue;
            }
        }

        return isPositive ? converted : -converted;
    }
}
