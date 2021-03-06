namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/3sum/">3Sum</see>.
/// </summary>
public static class Problem4
{
    /// <summary>
    /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
    /// Time complexity: O(n^2).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Triplets that add up to 0.</returns>
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0, length = nums.Length - 2; i < length; i++)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                TwoSum(nums, -nums[i], i + 1, nums.Length - 1, result);
            }
        }

        return result;
    }

    private static void TwoSum(int[] nums, int targetSum, int leftStart, int rightStart, IList<IList<int>> result)
    {
        for (int left = leftStart, right = rightStart; left < right;)
        {
            var sum = nums[left] + nums[right];

            if (sum < targetSum)
            {
                left++;
            }
            else if (sum > targetSum)
            {
                right--;
            }
            else
            {
                if (left == leftStart || right == rightStart || nums[left] != nums[left - 1] || nums[right] != nums[right + 1])
                {
                    result.Add(new List<int> { -targetSum, nums[left], nums[right] });
                }

                left++;
                right--;
            }
        }
    }
}
