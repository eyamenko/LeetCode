namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/non-overlapping-intervals/">Non-overlapping Intervals</see>.
/// </summary>
public static class Problem51
{
    /// <summary>
    /// Given an array of intervals intervals where intervals[i] = [starti, endi],
    /// return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.
    /// Time complexity: O(n log n).
    /// Space complexity: O(log n).
    /// </summary>
    /// <param name="intervals">Array to traverse.</param>
    /// <returns>Minimum number of intervals required to be removed to make the rest of the intervals non-overlapping.</returns>
    public static int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));

        var count = 0;

        for (var i = 1; i < intervals.Length; i++)
        {
            var (current, previous) = (intervals[i], intervals[i - 1]);

            if (current[0] < previous[1])
            {
                if (previous[1] < current[1])
                {
                    intervals[i] = previous;
                }

                count++;
            }
        }

        return count;
    }
}
