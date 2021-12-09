namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/maximum-product-subarray/">Maximum Product Subarray</see>.
/// </summary>
public static class Problem29
{
    /// <summary>
    /// Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Largest product of a contiguous non-empty subarray within the array.</returns>
    public static int MaxProduct(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var maxProduct = Math.Max(nums[0], nums[^1]);

        for (int left = 1, right = nums.Length - 2, leftProduct = nums[0], rightProduct = nums[^1]; left < nums.Length && right >= 0; left++, right--)
        {
            if (leftProduct == 0)
            {
                leftProduct = nums[left];
            }
            else
            {
                leftProduct *= nums[left];
            }

            if (rightProduct == 0)
            {
                rightProduct = nums[right];
            }
            else
            {
                rightProduct *= nums[right];
            }

            maxProduct = Math.Max(maxProduct, Math.Max(leftProduct, rightProduct));
        }

        return maxProduct;
    }
}
