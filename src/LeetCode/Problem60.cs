namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/divide-two-integers/">Divide Two Integers</see>.
/// </summary>
public static class Problem60
{
    private const double EPS = 1e-9;

    /// <summary>
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
    /// The integer division should truncate toward zero, which means losing its fractional part.
    /// For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
    /// Return the quotient after dividing dividend by divisor.
    /// Time complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="dividend">Dividend.</param>
    /// <param name="divisor">Divisor.</param>
    /// <returns>Quotient after dividing dividend by divisor.</returns>
    public static int Divide(int dividend, int divisor)
    {
        if (divisor == int.MinValue)
        {
            return dividend == divisor ? 1 : 0;
        }

        var result = 0;

        if (dividend == int.MinValue)
        {
            if (divisor == 1)
            {
                return int.MinValue;
            }

            if (divisor == -1)
            {
                return int.MaxValue;
            }

            dividend += Math.Abs(divisor);
            result++;
        }

        result += (int)(Math.Exp(Math.Log(Math.Abs(dividend)) - Math.Log(Math.Abs(divisor))) + EPS);

        return (dividend > 0) == (divisor > 0) ? result : -result;
    }
}
