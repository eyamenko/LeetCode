namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/insert-interval/">Insert Interval</see>.
/// </summary>
public static class Problem13
{
    /// <summary>
    /// You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti.
    /// You are also given an interval newInterval = [start, end] that represents the start and end of another interval.
    /// Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="intervals">Array to traverse.</param>
    /// <param name="newInterval">New interval to insert.</param>
    /// <returns>Intervals after the insertion.</returns>
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>(intervals.Length + 1);

        for (var (left, right) = (0, 0); left < intervals.Length || right < 1;)
        {
            if (right >= 1 || (left < intervals.Length && intervals[left][1] < newInterval[0]))
            {
                result.Add(intervals[left]);
                left++;
            }
            else if (left >= intervals.Length || (right < 1 && newInterval[1] < intervals[left][0]))
            {
                result.Add(newInterval);
                right++;
            }
            else
            {
                (newInterval[0], newInterval[1]) = (Math.Min(intervals[left][0], newInterval[0]), Math.Max(intervals[left][1], newInterval[1]));
                left++;
            }
        }

        return result.ToArray();
    }
}
