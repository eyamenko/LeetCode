namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/container-with-most-water/">Container With Most Water</see>.
/// </summary>
public static class Problem3
{
    /// <summary>
    /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai).
    /// n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0).
    /// Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="height">Array to traverse.</param>
    /// <returns>Max area of water the container can contain.</returns>
    public static int MaxArea(int[] height)
    {
        var maxArea = 0;

        for (int left = 0, right = height.Length - 1; left < right;)
        {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));

            if (height[left] < height[right])
            {
                left++;
            }
            else if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
                right--;
            }
        }

        return maxArea;
    }
}
