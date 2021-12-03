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
        if (intervals.Length < 2)
        {
            return intervals;
        }

        var mid = intervals.Length / 2;
        var left = intervals[..mid];
        var right = intervals[mid..];

        return Merge(Merge(left), Merge(right));
    }

    private static int[][] Merge(int[][] left, int[][] right)
    {
        var result = new List<int[]>(left.Length + right.Length);

        for (var (leftIdx, rightIdx) = (0, 0); leftIdx < left.Length || rightIdx < right.Length;)
        {
            if (rightIdx >= right.Length || (leftIdx < left.Length && left[leftIdx][1] < right[rightIdx][0]))
            {
                result.Add(left[leftIdx]);
                leftIdx++;
            }
            else if (leftIdx >= left.Length || (rightIdx < right.Length && right[rightIdx][1] < left[leftIdx][0]))
            {
                result.Add(right[rightIdx]);
                rightIdx++;
            }
            else
            {
                var interval = (Math.Min(left[leftIdx][0], right[rightIdx][0]), Math.Max(left[leftIdx][1], right[rightIdx][1]));

                if (left[leftIdx][1] > right[rightIdx][1])
                {
                    (left[leftIdx][0], left[leftIdx][1]) = interval;
                    rightIdx++;
                }
                else
                {
                    (right[rightIdx][0], right[rightIdx][1]) = interval;
                    leftIdx++;
                }
            }
        }

        return result.ToArray();
    }
}
