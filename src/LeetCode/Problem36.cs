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

        return Math.Max(RobV1(nums[..^1]), RobV1(nums[1..]));
    }

    private static int RobV1(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] = Math.Max(nums[i - 1], nums[i] + nums.ElementAtOrDefault(i - 2));
        }

        return nums[^1];
    }
}
