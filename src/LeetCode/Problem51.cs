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
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="intervals">Array to traverse.</param>
    /// <returns>Minimum number of intervals required to be removed to make the rest of the intervals non-overlapping.</returns>
    public static int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));

        var count = 0;

        for (int i = 1, j = 0; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[j][1])
            {
                count++;

                if (intervals[i][1] > intervals[j][1])
                {
                    continue;
                }
            }

            j = i;
        }

        return count;
    }
}
