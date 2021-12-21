namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/search-in-rotated-sorted-array/">Search in Rotated Sorted Array</see>.
/// </summary>
public static class Problem8
{
    /// <summary>
    /// There is an integer array nums sorted in ascending order (with distinct values).
    /// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 &lt;= k &lt; nums.length)
    /// such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed).
    /// For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
    /// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// Time complexity: O(log n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <param name="target">Target to find.</param>
    /// <returns>Index of target.</returns>
    public static int Search(int[] nums, int target)
    {
        for (int low = 0, high = nums.Length - 1; low <= high;)
        {
            var mid = (low + high) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if ((low != mid && nums[low] <= nums[mid - 1] && target >= nums[low] && target <= nums[mid - 1])
            || (high != mid && nums[mid + 1] <= nums[high] && (target < nums[mid + 1] || target > nums[high])))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }
}
