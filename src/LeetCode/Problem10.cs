namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/maximum-subarray/">Maximum Subarray</see>.
/// </summary>
public static class Problem10
{
    /// <summary>
    /// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Largest subarray sum.</returns>
    public static int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var globalSum = nums[0];

        for (var (i, currentSum) = (1, globalSum); i < nums.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = nums[i];
            }
            else
            {
                currentSum += nums[i];
            }

            globalSum = Math.Max(globalSum, currentSum);
        }

        return globalSum;
    }
}
