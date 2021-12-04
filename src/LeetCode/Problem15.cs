namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/climbing-stairs/">Climbing Stairs</see>.
/// </summary>
public static class Problem15
{
    /// <summary>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps. Find how many distinct ways you can climb to the top.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="n">Number of steps to reach the top.</param>
    /// <returns>Number of distinct ways you can climb to the top.</returns>
    public static int ClimbStairs(int n)
    {
        if (n < 4)
        {
            return n;
        }

        var second = 5;

        for (int i = 4, first = 3; i < n; i++)
        {
            second += first;
            first = second - first;
        }

        return second;
    }
}
