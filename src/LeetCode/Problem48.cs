namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/combination-sum-iv/">Combination Sum IV</see>.
/// </summary>
public static class Problem48
{
    /// <summary>
    /// Given an array of distinct integers `nums` and a target integer `target`, return the number of possible combinations that add up to `target`.
    /// Time complexity: O(n * t).
    /// Space complexity: O(t).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <param name="target">Target integer.</param>
    /// <returns>Number of possible combinations that add up to the target.</returns>
    public static int CombinationSum4(int[] nums, int target)
    {
        var dp = new int[target + 1];

        dp[0] = 1;

        for (var i = 1; i <= target; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] <= i)
                {
                    dp[i] += dp[i - nums[j]];
                }
            }
        }

        return dp[target];
    }
}
