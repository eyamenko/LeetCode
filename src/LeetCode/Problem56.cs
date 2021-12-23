namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/reverse-integer/">Reverse Integer</see>.
/// </summary>
public static class Problem56
{
    /// <summary>
    /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="x">Integer to reverse.</param>
    /// <returns>Reversed integer.</returns>
    public static int Reverse(int x)
    {
        var reversed = 0;

        for (; x != 0; x /= 10)
        {
            try
            {
                checked
                {
                    reversed *= 10;
                    reversed += x % 10;
                }
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        return reversed;
    }
}
