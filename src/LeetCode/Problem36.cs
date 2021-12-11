namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/house-robber-ii/">House Robber II</see>.
/// </summary>
public static class Problem36
{
    /// <summary>
    /// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed.
    /// All houses at this place are arranged in a circle. That means the first house is the neighbour of the last one.
    /// Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Maximum amount of money that can be robbed.</returns>
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

        var left = new int[nums.Length];
        var right = new int[nums.Length];

        for (int i = 0, j = nums.Length - 1; i < nums.Length && j >= 0; i++, j--)
        {
            if (i < 2)
            {
                left[i] = nums[i];
                right[j] = nums[j];
            }
            else if (i == 2)
            {
                left[i] = nums[i] + nums[0];
                right[j] = nums[j] + nums[^1];
            }
            else
            {
                left[i] = nums[i] + Math.Max(left[i - 2], left[i - 3]);
                right[j] = nums[j] + Math.Max(right[j + 2], right[j + 3]);
            }
        }

        return Math.Max(Math.Max(Math.Max(left[^1] - nums[0], right[0] - nums[^1]), Math.Max(left[^2], right[1])), Math.Max(nums[0], nums[^1]));
    }
}
