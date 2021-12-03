namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/jump-game/">Jump Game</see>.
/// </summary>
public static class Problem11
{
    /// <summary>
    /// You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
    /// Return true if you can reach the last index, or false otherwise.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <returns>True, if the last index can be reached.</returns>
    public static bool CanJump(int[] nums)
    {
        for (var (i, maxIndex) = (0, 0); maxIndex < nums.Length - 1; i++)
        {
            maxIndex = Math.Max(maxIndex, nums[i] + i);

            if (maxIndex == i)
            {
                return false;
            }
        }

        return true;
    }
}
