namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/">Find Minimum in Rotated Sorted Array</see>.
/// </summary>
public static class Problem30
{
    /// <summary>
    /// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
    /// You must write an algorithm that runs in O(log n) time.
    /// Time complexity: O(log n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Minimum element.</returns>
    public static int FindMin(int[] nums)
    {
        var low = 0;
        var high = nums.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var leftMin = Math.Min(nums[low], nums[Math.Max(low, mid - 1)]);
            var rightMin = Math.Min(nums[Math.Min(high, mid + 1)], nums[high]);

            if (leftMin < rightMin && leftMin < nums[mid])
            {
                high = mid - 1;
            }
            else if (rightMin < leftMin && rightMin < nums[mid])
            {
                low = mid + 1;
            }
            else
            {
                return nums[mid];
            }
        }

        return -1;
    }
}
