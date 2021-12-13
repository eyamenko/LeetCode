namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-increasing-subsequence/">Longest Increasing Subsequence</see>.
/// </summary>
public static class Problem45
{
    /// <summary>
    /// Given an integer array nums, return the length of the longest strictly increasing subsequence.
    /// Time complexity: O(n^2).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Length of the longest strictly increasing subsequence.</returns>
    public static int LengthOfLIS(int[] nums)
    {
        var maxLength = 0;
        var lengths = new int[nums.Length];

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    lengths[i] = Math.Max(lengths[i], lengths[j]);
                }
            }

            lengths[i]++;

            maxLength = Math.Max(maxLength, lengths[i]);
        }

        return maxLength;
    }
}
