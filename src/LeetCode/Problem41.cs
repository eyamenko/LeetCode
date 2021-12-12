namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/product-of-array-except-self/">Product of Array Except Self</see>.
/// </summary>
public static class Problem41
{
    /// <summary>
    /// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
    /// You must write an algorithm that runs in O(n) time and without using the division operation.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Product of array except self.</returns>
    public static int[] ProductExceptSelf(int[] nums)
    {
        var left = new int[nums.Length];
        var right = new int[nums.Length];

        left[0] = nums[0];
        right[^1] = nums[^1];

        for (int i = 1, j = nums.Length - 2; i < nums.Length && j >= 0; i++, j--)
        {
            left[i] = left[i - 1] * nums[i];
            right[j] = right[j + 1] * nums[j];
        }

        nums[0] = right[1];
        nums[^1] = left[^2];

        for (var i = 1; i < nums.Length - 1; i++)
        {
            nums[i] = left[i - 1] * right[i + 1];
        }

        return nums;
    }
}
