namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/merge-intervals/">Merge Intervals</see>.
/// </summary>
public static class Problem12
{
    /// <summary>
    /// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals,
    /// and return an array of the non-overlapping intervals that cover all the intervals in the input.
    /// Time complexity: O(n log n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="intervals">Array to traverse.</param>
    /// <returns>Array of the non-overlapping intervals that cover all the intervals in the input.</returns>
    public static int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));

        var result = new List<int[]>(intervals.Length);

        for (var i = 1; i < intervals.Length; i++)
        {
            var (current, previous) = (intervals[i], intervals[i - 1]);

            if (current[0] <= previous[1])
            {
                current[0] = Math.Min(current[0], previous[0]);
                current[1] = Math.Max(current[1], previous[1]);
            }
            else
            {
                result.Add(previous);
            }
        }

        result.Add(intervals[^1]);

        return result.ToArray();
    }
}
