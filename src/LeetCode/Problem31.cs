namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/house-robber/">House Robber</see>.
/// </summary>
public static class Problem31
{
    /// <summary>
    /// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed,
    /// the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and
    /// it will automatically contact the police if two adjacent houses were broken into on the same night.
    /// Given an integer array nums representing the amount of money of each house,
    /// return the maximum amount of money you can rob tonight without alerting the police.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Maximum amount of money.</returns>
    public static int Rob(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        for (var i = nums.Length - 3; i >= 0; i--)
        {
            nums[i] += Math.Max(nums[i + 2], nums[Math.Min(i + 3, nums.Length - 1)]);
        }

        return Math.Max(nums[0], nums[1]);
    }
}
