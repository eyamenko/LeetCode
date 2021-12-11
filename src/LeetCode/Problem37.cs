namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/contains-duplicate/">Contains Duplicate</see>.
/// </summary>
public static class Problem37
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>True, if any value appears at least twice in the array.</returns>
    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
