namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-consecutive-sequence/">Longest Consecutive Sequence</see>.
/// </summary>
public static class Problem25
{
    /// <summary>
    /// Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
    /// You must write an algorithm that runs in O(n) time.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>Length of the longest consecutive elements sequence.</returns>
    public static int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
#pragma warning disable IDE0058
            set.Add(nums[i]);
#pragma warning restore IDE0058
        }

        var maxLength = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (set.Remove(nums[i]))
            {
                var leftCount = 0;

                while (set.Remove(nums[i] - leftCount - 1))
                {
                    leftCount++;
                }

                var rightCount = 0;

                while (set.Remove(nums[i] + rightCount + 1))
                {
                    rightCount++;
                }

                maxLength = Math.Max(maxLength, leftCount + rightCount + 1);
            }
        }

        return maxLength;
    }
}
