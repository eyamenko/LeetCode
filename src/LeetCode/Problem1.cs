namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/two-sum/">Two Sum</see>.
/// </summary>
public static class Problem1
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <param name="target">Target sum.</param>
    /// <returns>Indices of the two numbers that add up to the target.</returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (dict.ContainsKey(diff))
            {
                return new[] { dict[diff], i };
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }

        return Array.Empty<int>();
    }
}
